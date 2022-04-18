using System;

using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public class F64 : Floating<Insn.Num.F64Impl, double>
    {
        protected override Insn.Num.F64Impl Impl => Insn.F64;

        public F64(Builtins builtins)
            : base(builtins, Names.Core.F64, WasmType.F64)
        {
        }
    }
}
