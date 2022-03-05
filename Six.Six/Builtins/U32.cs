using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public class U32 : I32
    {
        public U32(Resolver resolver)
            : base(resolver)
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

            var zero = new Expr.ConstU32(this, 0);
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

            return new Expr.Binop(this, Insn.U32.Add, left, right);
        }

        public Expr.Primitive Sub(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.U32.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.U32.Mul, left, right);
        }

        public Expr.Primitive Div(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.U32.Div, left, right);
        }

        public Expr.Primitive Rem(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.U32.Rem, left, right);
        }
    }
}
