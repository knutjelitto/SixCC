using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Floating : Number
    {
        public Floating(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
