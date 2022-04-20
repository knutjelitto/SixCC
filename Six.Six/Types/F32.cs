using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public class F32 : Floating<Insn.Num.F32Impl, float>
    {
        protected override Insn.Num.F32Impl Impl => Insn.F32;

        public F32(Builtins builtins)
            : base(builtins, Names.Core.F32, WasmType.F32)
        {
        }
    }
}
