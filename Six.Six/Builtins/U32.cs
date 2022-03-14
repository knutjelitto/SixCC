using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class U32 : I32
    {
        public U32(Builtins builtins) : base(builtins, Names.Core.UInt32)
        {
            prefix.Add("-", Neg);
            prefix.Add("!", Not);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
            infix.Add("%", Rem);
        }

        public Expression.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expression.ConstU32(this, 0);
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

            return new Expression.Binop(this, Insn.U32.Add, left, right);
        }

        public Expression.Primitive Sub(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.U32.Sub, left, right);
        }

        public Expression.Primitive Mul(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.U32.Mul, left, right);
        }

        public Expression.Primitive Div(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.U32.Div, left, right);
        }

        public Expression.Primitive Rem(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expression.Binop(this, Insn.U32.Rem, left, right);
        }
    }
}
