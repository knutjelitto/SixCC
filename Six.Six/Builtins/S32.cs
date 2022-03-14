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

        public Expression.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expression.ConstI32(this, 0);
            return Sub(zero, right);
        }

        public Expression.Primitive Not(Expr right)
        {
            Assert(IsThis(right));

            throw new NotImplementedException();
        }

        public Expression.Primitive Add(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.I32.Add, left, right);
        }

        public Expression.Primitive Sub(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.I32.Sub, left, right);
        }

        public Expression.Primitive Mul(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.I32.Mul, left, right);
        }

        public Expression.Primitive Div(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.I32.Div, left, right);
        }

        public Expression.Primitive Rem(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.I32.Rem, left, right);
        }

        public Expression.Primitive LessThanOrEqual(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(Builtins.Boolean, Insn.I32.Le, left, right);
        }
    }
}
