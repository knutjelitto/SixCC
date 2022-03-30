using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Types
{
    public sealed class U32 : I32<Insn.U32Impl, uint>
    {
        protected override Insn.U32Impl Impl => Insn.U32;

        public U32(Builtins builtins)
            : base(builtins, Names.Core.U32)
        {
        }

        public override Primitive Not(Expr arg)
        {
            Assert(IsThis(arg));

            var ones = new Primitive.ConstU32(this, uint.MaxValue);
            return Xor(ones, arg);
        }
    }
}
