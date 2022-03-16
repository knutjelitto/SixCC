using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class F64 : Floating
    {
        public F64(Builtins builtins)
            : base(builtins, Names.Core.Float64, WasmDef.F64)
        {
            prefix.Add("-", Neg);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
        }

        public override Insn Load(uint offset)
        {
            return Insn.F64.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Insn.F64.Store(offset);
        }

        public Expr.Unop Neg(Expr right)
        {
            IsThis(right);

            return new Expr.Unop(this, Insn.F64.Neg, right);
        }

        public Expr.Primitive Add(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expr.Binop(this, Insn.F64.Add, left, right);
        }

        public Expr.Primitive Sub(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expr.Binop(this, Insn.F64.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expr.Binop(this, Insn.F64.Mul, left, right);
        }

        public Expr.Primitive Div(Expr left, Expr right)
        {
            IsThis(left);
            IsThis(right);

            return new Expr.Binop(this, Insn.F64.Div, left, right);
        }
    }
}
