using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class F64 : Floating
    {
        public F64(Builtins builtins) : base(builtins, Names.Core.Float64)
        {
            prefix.Add("-", Neg);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
        }

        public override string AsWasm => "f64";

        public Expression.Unop Neg(Expr right)
        {
            IsThis(right);

            return new Expression.Unop(this, Insn.F64.Neg, right);
        }

        public Expression.Primitive Add(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expression.Binop(this, Insn.F64.Add, left, right);
        }

        public Expression.Primitive Sub(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expression.Binop(this, Insn.F64.Sub, left, right);
        }

        public Expression.Primitive Mul(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expression.Binop(this, Insn.F64.Mul, left, right);
        }

        public Expression.Primitive Div(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expression.Binop(this, Insn.F64.Div, left, right);
        }
    }
}
