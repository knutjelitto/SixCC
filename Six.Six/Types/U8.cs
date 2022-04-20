using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Types
{
    public sealed class U8 : I32<Insn.Num.U8Impl, byte>
    {
        protected override Insn.Num.U8Impl Impl => Insn.U8;

        public U8(Builtins builtins)
            : base(builtins, Names.Core.U8)
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
