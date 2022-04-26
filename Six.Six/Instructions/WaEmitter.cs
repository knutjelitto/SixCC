using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Instructions
{
    public class WaEmitter : WithWriter
    {
        public WaEmitter(Module module, WaModule waModule, WaWalker waWalker)
            : base(new Writer())
        {
            Module = module;

            WaModule = waModule;
            WaWalker = waWalker;
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
