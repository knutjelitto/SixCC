using Six.Core;
using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaModule : WithWriter
    {
        private readonly WaFunctionList Functions;
        private readonly WaClassyList Classies;
        public readonly WAFunctionTypeList FunctionTypes;

        public WaModule() : base(new Writer())
        {
            Functions = new();
            Classies = new(this);
            FunctionTypes = new(this);
        }

        public WaFunction Add(WaFunction function)
        {
            Functions.Add(function);

            return function;
        }

        public WaClassy Add(WaClassy classy)
        {
            Classies.Add(classy);

            return classy;
        }

        private void Prepare()
        {
            foreach (var function in Functions)
            {
                function.Prepare();
            }

            foreach (var classy in Classies)
            {
                classy.Prepare();
            }
        }

        public void Emit()
        {
            Prepare();

            w("(module");
            indent(() =>
            {
                for (var i = 0; i < Functions.Count; i++)
                {
                    wl();
                    Functions[i].Emit();
                }

                for (var i = 0; i < Classies.Count; i++)
                {
                    Classies[i].Emit();
                }

                FunctionTypes.Emit();
            });
            wl(")");
        }
    }
}
