using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Instructions
{
    public class WaEmitter : WithWriter
    {
        public WaEmitter(Module module)
            : base(new Writer())
        {
            Module = module;
            Emitter = new Emitter(Module);
            WaModule = Emitter.WaModule;
            WaWalker = Emitter.WaWalker;
        }

        public readonly Emitter Emitter;
        public readonly Module Module;
        public readonly WaModule WaModule;
        public readonly WaWalker WaWalker;

        public void EmitModule()
        {
            if (Module.HasErrors)
            {
                return;
            }

            foreach (var global in Module.GetGlobals())
            {
                WaWalker.AddGlobal(global);
            }

            foreach (var function in Module.GetFunctions())
            {
                WaWalker.AddFunction(function);
            }

            foreach (var classy in Module.GetClassies())
            {
                WaWalker.AddClass(classy);
            }

            WaWalker.AddModuleInitializer();

            WaModule.Prepare();
            WaModule.Emit();
        }
    }
}
