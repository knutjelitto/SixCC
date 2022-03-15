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

        public Expr.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expr.ConstU32(this, 0);
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

            return new Expr.Binop(this, Insn.U32.Add, left, right);
        }

        public Expr.Primitive Sub(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.U32.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.U32.Mul, left, right);
        }

        public Expr.Primitive Div(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.U32.Div, left, right);
        }

        public Expr.Primitive Rem(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(this, Insn.U32.Rem, left, right);
        }
    }
}
