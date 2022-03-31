using Six.Core;
using Six.Runtime;
using Six.Six.Sema;

namespace Six.Six.Wasms
{
    public class WaModule : WithWriter
    {
        public static string GlobalFunctionsTableName => Module.ModuleFunctions;

        private readonly WaFunctionList Functions;
        private readonly WaClassList Classes;

        public readonly WaFunctionTable GlobalFunctions;
        public readonly WaFunctionTypeList FunctionTypes;

        public readonly Dictionary<string, WaFunction> FunctionIndex;
        public readonly Dictionary<string, WaClass> ClassIndex;

        public WaModule(Module semaModule) : base(new Writer())
        {
            Functions = new();
            Classes = new(this);
            GlobalFunctions = new WaFunctionTable(this, GlobalFunctionsTableName);
            FunctionTypes = new(this);
            FunctionIndex = new();
            ClassIndex = new();
            SemaModule = semaModule;
        }

        public Module SemaModule { get; }


        public WaFunction Add(WaFunction function)
        {
            Functions.Add(function);

            return function;
        }

        public WaClass Add(WaClass clazz)
        {
            Classes.Add(clazz);

            return clazz;
        }

        private void Prepare()
        {
            foreach (var function in Functions)
            {
                function.Prepare();
            }

            foreach (var classy in Classes)
            {
                classy.Prepare();
            }

            GlobalFunctions.Prepare();
            FunctionTypes.Prepare();
        }

        public void Emit()
        {
            Prepare();

            wl("(module");
            indent(() =>
            {
                for (var i = 0; i < Functions.Count; i++)
                {
                    if (i > 0) wl();
                    Functions[i].Emit();
                }
                wl();

                for (var i = 0; i < Classes.Count; i++)
                {
                    if (i > 0) wl();
                    Classes[i].Emit();
                }
                wl();
                GlobalFunctions.Emit();
                wl();
                FunctionTypes.Emit();
            });
            wl(")");
        }
    }
}
