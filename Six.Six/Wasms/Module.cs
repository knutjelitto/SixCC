using Six.Core;
using Six.Runtime;

namespace Six.Six.Wasms
{
    public class Module : WithWriter
    {
        private readonly FunctionList Functions;
        public readonly FunctionTypes FunctionTypes;

        public Module() : base(new Writer())
        {
            Functions = new();
            FunctionTypes = new(this);
        }

        public Function Add(Function function)
        {
            Functions.Add(function);

            return function;
        }

        private void Prepare()
        {
            foreach (var function in Functions)
            {
                function.Prepare();
            }
        }

        public void Emit()
        {
            Prepare();

            wl("(;");
            indent(() =>
            {
                w("(module (;;)");
                indent(() =>
                {
                    for (var i = 0; i < Functions.Count; i++)
                    {
                        wl();
                        Functions[i].Emit();
                    }

                    FunctionTypes.Emit();
                });
                wl(")");
            });
            wl(";)");
        }
    }
}
