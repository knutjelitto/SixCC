using System;

using Six.Six.Instructions;
using Six.Six.Sema;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public class F64 : Floating<Insn.F64Impl, double>
    {
        protected override Insn.F64Impl Impl => Insn.F64;

        public F64(Builtins builtins)
            : base(builtins, Names.Core.F64, W.WasmType.F64)
        {
        }
    }
}
