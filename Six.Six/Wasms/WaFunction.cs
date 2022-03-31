using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFunction : WithWriter
    {
        private string? signature;

        private readonly WaParameterList Parameters;
        private readonly WaResultList Results;
        private readonly WaLocalList Locals;
        private readonly WaInstructionList Instructions = new();

        public WaFunction(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
            Parameters = new(this);
            Results = new(this);
            Locals = new(this);
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

        public string Signature
        {
            get
            {
                if (signature == null)
                {
                    var builder = new StringBuilder();
                    builder.Append("(param");
                    foreach (var param in Parameters)
                    {
                        builder.Append($" {param.Type}");
                    }
                    builder.Append($") (result");
                    foreach (var result in Results)
                    {
                        builder.Append($" {result.Type}");
                    }
                    builder.Append(')');

                    signature = builder.ToString();
                }
                return signature;
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
