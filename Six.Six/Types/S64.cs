using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Types
{
    public class S64 : I64<Insn.Num.S64Impl, long>
    {
        protected override Insn.Num.S64Impl Impl => Insn.S64;

        public S64(Builtins builtins)
            : base(builtins, Names.Core.S64)
        {
            AddPrefix("-", Neg);
        }

        public Primitive Neg(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var zero = new Primitive.ConstS64(this, 0);
            return Sub(new List<Expr> { zero, args[0] });
        }

        public override Primitive Not(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var ones = new Primitive.ConstS64(this, -1);
            return Xor(new List<Expr> { ones, args[0] });
        }

    }
}
