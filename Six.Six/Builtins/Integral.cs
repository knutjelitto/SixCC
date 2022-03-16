using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Integral : Number
    {
        public Integral(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
