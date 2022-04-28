using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Types
{
    public sealed class U16 : I32<Insn.Num.U16Impl, ushort>
    {
        protected override Insn.Num.U16Impl Impl => Insn.U16;

        public U16(Builtins builtins)
            : base(builtins, Names.Core.U16)
        {
        }

        public override Primitive Not(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var ones = new Primitive.ConstU32(this, uint.MaxValue);
            return Xor(new List<Expr> { ones, args[0] });
        }
    }
}
