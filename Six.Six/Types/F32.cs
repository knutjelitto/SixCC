using Six.Six.Instructions;
using Six.Six.Sema;

using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public class F32 : Floating<Insn.F32Impl, float>
    {
        protected override Insn.F32Impl Impl => Insn.F32;

        public F32(Builtins builtins)
            : base(builtins, Names.Core.F32, W.WasmType.F32)
        {
        }
    }
}
