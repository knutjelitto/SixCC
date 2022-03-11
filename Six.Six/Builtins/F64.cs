using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class F64 : Floating
    {
        public F64() : base(Names.Core.Float64)
        {
            prefix.Add("-", Neg);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
        }

        public override string AsWasm => "f64";

        public Expr.Unop Neg(Expr.Concrete right)
        {
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Unop(this, Insn.F64.Neg, right);
        }

        public Expr.Primitive Add(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F64.Add, left, right);
        }

        public Expr.Primitive Sub(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F64.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F64.Mul, left, right);
        }

        public Expr.Primitive Div(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F64.Div, left, right);
        }
    }
}
