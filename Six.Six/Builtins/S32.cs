using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class S32 : I32
    {
        public S32(Builtins builtins) : base(builtins, Names.Core.Int32)
        {
            prefix.Add("-", Neg);
            prefix.Add("!", Not);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
            infix.Add("%", Rem);
            infix.Add("<=", LessThanOrEqual);
        }

        public Expr.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expr.ConstI32(this, 0);
            return Sub(zero, right);
        }

        public Expr.Primitive Not(Expr right)
        {
            Assert(IsThis(right));

            throw new NotImplementedException();
        }

        public Expr.Primitive Add(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.I32.Add, left, right);
        }

        public Expr.Primitive Sub(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.I32.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.I32.Mul, left, right);
        }

        public Expr.Primitive Div(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.I32.Div, left, right);
        }

        public Expr.Primitive Rem(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.I32.Rem, left, right);
        }

        public Expr.Primitive LessThanOrEqual(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(Builtins.Boolean, Insn.I32.Le, left, right);
        }
    }
}
