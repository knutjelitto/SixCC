using Six.Runtime;

namespace Six.Six.Wasms
{
    public sealed class WaFunction : WithWriter, Wamber
    {
        private WaFuncSignature? signature;

        public readonly WaParameterList Parameters;
        public readonly WaResultList Results;
        private readonly WaLocalList Locals;
        public readonly WaInstructionList Instructions = new();

        public readonly WaFunctionList InnerFunctions = new();

        private WaFunction(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
            Parameters = new(this);
            Results = new(this);
            Locals = new(this);
        }

        public static WaFunction From(WaModule module, string name)
        {
            if (!module.FunctionIndex.TryGetValue(name, out var function))
            {
                function = new WaFunction(module, name);
                module.FunctionIndex.Add(name, function);
            }

            return function;
        }

        public WaModule Module { get; }
        public string Name { get; }
        public WaFunctionType? Type { get; private set; } = null;

        public void Add(WaParameter parameter)
        {
            Assert(Locals.Count == 0);
            parameter.Index = Parameters.Count;
            Parameters.Add(parameter);
        }

        public void Add(WaResult result)
        {
            Results.Add(result);
        }

        public void Add(WaLocal local)
        {
            local.Index = Parameters.Count + Locals.Count;
            Locals.Add(local);
        }

        public void Add(WaInstruction instruction)
        {
            Instructions.Add(instruction);
        }

        public void Add(WaFunction innerFunction)
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
                w("(param");
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
