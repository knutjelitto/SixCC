using Six.Runtime;

namespace Six.Six.Wasms
{
    public sealed class WaFunction : WithWriter, Wamber
    {
        private WaFuncSignature? signature;

        public readonly WaParameterList Parameters;
        public readonly WaResultList Results;
        private readonly WaLocalList Locals;
        public readonly WaInstructionList Instructions;

        public readonly WaFunctionList InnerFunctions;

        private WaFunction(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
            Parameters = new(this);
            Results = new(this);
            Locals = new(this);
            Instructions = new(this);
            InnerFunctions = new(this);
        }

        public WaModule Module { get; }
        public string Name { get; }
        public bool Export { get; set; } = true;
        public WaFunctionType? Type { get; private set; } = null;

        public static WaFunction From(WaModule module, string name)
        {
            return module.NewFunction(name, () => new WaFunction(module, name));
        }

        public void AddParameter(WaParameter parameter)
        {
            Assert(Locals.Count == 0);
            parameter.Index = Parameters.Count;
            Parameters.Add(parameter);
        }

        public void AddResult(WaResult result)
        {
            Results.Add(result);
        }

        public void AddLocal(WaLocal local)
        {
            local.Index = Parameters.Count + Locals.Count;
            Locals.Add(local);
        }

        public void AddInstruction(WaInstruction instruction)
        {
            Instructions.Add(instruction);
        }

        public void AddLocal(WaFunction innerFunction)
        {
            InnerFunctions.Add(innerFunction);
        }

        public WaLocal GetLocal(int index)
        {
            return Locals[index - Parameters.Count];
        }

        public static string GetSignature(WaFunction function)
        {
            return GetSignature(function.Parameters.Select(p => p.Type), function.Results.Select(r => r.Type));
        }

        public static string GetSignature(IEnumerable<WasmType> parameters, WasmType result)
        {
            return GetSignature(parameters, Enumerable.Repeat(result, 1));
        }

        public static string GetSignature(IEnumerable<WasmType> parameters, IEnumerable<WasmType> results)
        {
            var builder = new StringBuilder();
            builder.Append("(param");
            foreach (var param in parameters)
            {
                builder.Append($" {param.Type}");
            }
            builder.Append($") (result");
            foreach (var result in results)
            {
                builder.Append($" {result.Type}");
            }
            builder.Append(')');

            var signature = builder.ToString();

            return $"(func {signature})";
        }

        public WaFuncSignature Signature => signature ??= WaFuncSignature.From(this);

        private void EmitExport()
        {
            if (Export)
            {
                wl($"(export \"{Name}\")");
            }
        }

        private void EmitParameters()
        {
            if (Parameters.Count > 0)
            {
                w("(param");
                foreach (var param in Parameters)
                {
                    w($" (; {param.Index}/{param.Name} ;) {param.Type}");
                }
                wl(")");
            }
        }


        private void EmitLocals()
        {
            if (Locals.Count > 0)
            {
                w("(local");
                foreach (var local in Locals)
                {
                    w($" (; {local.Index}/{local.Name} ;) {local.Type}");
                }
                wl(")");
            }
        }

        private void EmitResults()
        {
            if (Results.Count > 0)
            {
                w("(result");
                foreach (var result in Results)
                {
                    w($" {result.Type}");
                }
                wl(")");
            }
        }

        private void EmitInstructions()
        {
            foreach (var instruction in Instructions)
            {
                instruction.Emit();
            }
        }


        public void Emit()
        {
            Type = Type ?? throw new System.NullReferenceException();

            foreach (var inner in InnerFunctions)
            {
                inner.Emit();
                wl();
            }

            wl($"(func ${Name}");
            indent(() =>
            {
                EmitExport();
                EmitParameters();
                EmitResults();
                EmitLocals();
                wl(";; -----");
                EmitInstructions();
                wl(";; -----");
            });
            wl(")");
        }

        public void Prepare()
        {
            Type = Module.FunctionTypes.Add(this);

            foreach (var inner in InnerFunctions)
            {
                inner.Prepare();
            }

            foreach (var instruction in Instructions)
            {
                instruction.Prepare();
            }

            var index = 0;
            foreach (var parameter in Parameters)
            {
                Assert(parameter.Index == index);
                parameter.Index = index++;
            }
            foreach (var local in Locals)
            {
                Assert(local.Index == index);
                local.Index = index++;
            }
        }
    }
}
