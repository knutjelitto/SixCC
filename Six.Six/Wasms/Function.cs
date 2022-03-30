using Six.Runtime;

namespace Six.Six.Wasms
{
    public class Function : WithWriter
    {
        private string? signature;

        private readonly ParameterList Parameters = new();
        private readonly ResultList Results = new();
        private readonly LocalList Locals = new();
        private readonly InstructionList Instructions = new();

        public Function(Module module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
        }

        public Module Module { get; }
        public string Name { get; }
        public string FunctionType { get; private set; } = "";

        public void Add(Parameter parameter)
        {
            Parameters.Add(parameter);
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
            FunctionType = Module.FunctionTypes.FindType(this);

            foreach (var instruction in Instructions)
            {
                instruction.Prepare();
            }

            var index = 0;
            foreach (var parameter in Parameters)
            {
                parameter.Index = index++;
            }
            foreach (var local in Locals)
            {
                local.Index = index++;
            }
        }
    }
}
