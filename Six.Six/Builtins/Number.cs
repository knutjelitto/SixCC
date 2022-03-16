using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Number : Builtin
    {
        public Number(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm) { }
    }
}
