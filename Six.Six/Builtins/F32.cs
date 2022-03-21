using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class F32 : Floating
    {
        public F32(Builtins builtins)
            : base(builtins, Names.Core.F32, WasmDef.F32)
        {
            prefix.Add("-", Neg);
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);
        }

        public Expr.Primitive Neg(Expr right)
        {
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Unop(this, Insn.F32.Neg, right);
        }

        public override Insn Load(uint offset)
        {
            return Insn.F32.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Insn.F32.Store(offset);
        }

        public Expr.Primitive Add(Expr left, Expr right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F32.Add, left, right);
        }

        public Expr.Primitive Sub(Expr left, Expr right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F32.Sub, left, right);
        }

        public Expr.Primitive Mul(Expr left, Expr right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F32.Mul, left, right);
        }

        public Expr.Primitive Div(Expr left, Expr right)
        {
            Assert(ReferenceEquals(left.Type, this));
            Assert(ReferenceEquals(right.Type, this));

            return new Expr.Binop(this, Insn.F32.Div, left, right);
        }
    }
}
