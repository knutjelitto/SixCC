using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class I64<TInsn, TValue> : Inn<TInsn, TValue>
        where TInsn : Insn.Num.Inn<TValue>
        where TValue : struct
    {
        protected I64(Builtins builtins, string name)
            : base(builtins, name, WasmType.I64)
        {
        }
    }
}
