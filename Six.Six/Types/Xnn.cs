using Six.Six.Instructions;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Xnn<TInsn,TValue> : BuiltinCore
        where TInsn : Insn.Xnn<TValue>
        where TValue : struct
    {
        protected Xnn(Builtins builtins, string name, W.WasmType wasm)
            : base(builtins, name, wasm)
        {
        }
    }
}
