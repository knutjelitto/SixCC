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

            WaModule = new WaModule(module, Module.MetaClassName, Module.StringClassName);
            WaWalker = new WaWalker(WaModule);
        }

        public readonly Module Module;
        public readonly WaModule WaModule;
        public readonly WaWalker WaWalker;

        public void EmitModule()
        {
            Assert(!Module.HasErrors);

            WaWalker.Walk();

            WaModule.Prepare();
            WaModule.Emit();
        }
    }
}
