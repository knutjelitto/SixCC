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

            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
            infix.Add("%", Rem);

            prefix.Add("~", Complement);
            infix.Add("&", And);
            infix.Add("|", Or);
            infix.Add("^", Xor);

            infix.Add("<=", LessThanOrEqual);
        }

        public override Insn Load(uint offset)
        {
            return Insn.I32.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Insn.I32.Store(offset);
        }

        public Expr.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expr.ConstI32(this, 0);
            return Sub(zero, right);
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

            return new Expr.Binop(this, Insn.I32.And, arg1, arg2);
        }

        public Expr.Primitive Or(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.I32.Or, arg1, arg2);
        }

        public Expr.Primitive Xor(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Insn.I32.Xor, arg1, arg2);
        }
    }
}
