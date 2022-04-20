using Six.Six.Instructions;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Xnn<TInsn,TValue> : Builtin
        where TInsn : Insn.Num.Xnn<TValue>
        where TValue : struct
    {
        protected Xnn(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
