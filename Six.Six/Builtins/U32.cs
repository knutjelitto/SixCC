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
        public U32(Builtins builtins) : base(builtins, Names.Core.U32)
        {
            prefix.Add("-", Neg);

            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
            infix.Add("%", Rem);

            prefix.Add("~", Complement);
            infix.Add("&", And);
            infix.Add("|", Or);
            infix.Add("^", Xor);

            infix.Add("<=", LE);
            infix.Add("<", LT);
            infix.Add(">=", GE);
            infix.Add(">", GT);
        }

        public override Insn Load(uint offset)
        {
            return Insn.U32.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Insn.U32.Store(offset);
        }

        public Expr.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expr.ConstU32(this, 0);
            return Sub(zero, right);
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

        public Expr.Primitive Rem(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.U32.Rem, arg1, arg2);
        }


        public Expr.Primitive LE(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(Builtins.Boolean, Insn.U32.LE, left, right);
        }

        public Expr.Primitive LT(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(Builtins.Boolean, Insn.U32.LT, left, right);
        }

        public Expr.Primitive GE(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(Builtins.Boolean, Insn.U32.GE, left, right);
        }

        public Expr.Primitive GT(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Expr.Binop(Builtins.Boolean, Insn.U32.GT, left, right);
        }

        public Expr.Primitive Complement(Expr arg)
        {
            Assert(IsThis(arg));

            var ones = new Expr.ConstU32(this, uint.MaxValue);
            return Xor(ones, arg);
        }

        public Expr.Primitive And(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.U32.And, arg1, arg2);
        }

        public Expr.Primitive Or(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.U32.Or, arg1, arg2);
        }

        public Expr.Primitive Xor(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.U32.Xor, arg1, arg2);
        }
    }
}
