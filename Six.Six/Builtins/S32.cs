using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class S32 : I32
    {
        public S32()
        {
            prefix.Add("-", Neg);
            prefix.Add("!", Not);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
            infix.Add("%", Rem);
        }

        public Expr.Primitive Neg(Expr.Concrete right)
        {
            Assert(ReferenceEquals(right.Type, this));

            var zero = new Expr.ConstI32(this, 0);
            return Sub(zero, right);
        }

        public Expr.Primitive Not(Expr.Concrete right)
        {
            Assert(ReferenceEquals(right.Type, this));

            throw new NotImplementedException();
        }

        public Expr.Primitive Add(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.I32.Add, left, right);
        }

        public Expr.Primitive Sub(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.I32.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.I32.Mul, left, right);
        }

        public Expr.Primitive Div(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.I32.Div, left, right);
        }

        public Expr.Primitive Rem(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.I32.Rem, left, right);
        }
    }
}
