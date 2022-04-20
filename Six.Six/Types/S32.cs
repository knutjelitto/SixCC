using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Types
{
    public class S32 : I32<Insn.Num.S32Impl, int>
    {
        protected override Insn.Num.S32Impl Impl => Insn.S32;

        public S32(Builtins builtins) : base(builtins, Names.Core.S32)
        {
            AddPrefix("-", Neg);
        }

        public Primitive Neg(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var zero = new Primitive.ConstS32(this, 0);
            return Sub(new List<Expr> { zero, args[0] });
        }

        public override Primitive Not(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var ones = new Primitive.ConstS32(this, -1);
            return Xor(new List<Expr> { ones, args[0] });
        }

    }
}
