using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public class I32 : Integral
    {
        public I32()
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
            Assert(right.Type != null);
            Assert(right.Type is Sema.Type.BuiltinReference rightRef && rightRef.Builtin == this);
            if (right is Expr.ConstI32 natural)
            {
                var value = -natural.Value;
                return new Expr.ConstI32(this, value);
            }

            var zero = new Expr.ConstI32(this, 0);
            return Sub(zero, right);
        }
        public Expr.Primitive Not(Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
        public Expr.Primitive Add(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(left.Type is Sema.Type.BuiltinReference leftRef && leftRef.Builtin == this);
            Assert(right.Type is Sema.Type.BuiltinReference rightRef && rightRef.Builtin == this);
            if (left is Expr.ConstI32 natural1 && right is Expr.ConstI32 natural2)
            {
                var value = natural1.Value + natural2.Value;
                return new Expr.ConstI32(this, value);
            }
            return new Expr.Binop(this, Insn.I32.Add(), left, right);
        }
        public Expr.Primitive Sub(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(left.Type is Sema.Type.BuiltinReference leftRef && leftRef.Builtin == this);
            Assert(right.Type is Sema.Type.BuiltinReference rightRef && rightRef.Builtin == this);
            if (left is Expr.ConstI32 natural1 && right is Expr.ConstI32 natural2)
            {
                var value = natural1.Value - natural2.Value;
                return new Expr.ConstI32(this, value);
            }
            return new Expr.Binop(this, Insn.I32.Sub(), left, right);
        }
        public Expr.Primitive Mul(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(left.Type is Sema.Type.BuiltinReference leftRef && leftRef.Builtin == this);
            Assert(right.Type is Sema.Type.BuiltinReference rightRef && rightRef.Builtin == this);
            if (left is Expr.ConstI32 natural1 && right is Expr.ConstI32 natural2)
            {
                var value = natural1.Value * natural2.Value;
                return new Expr.ConstI32(this, value);
            }
            return new Expr.Binop(this, Insn.I32.Mul(), left, right);
        }
        public Expr.Primitive Div(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
        public Expr.Primitive Rem(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
    }
}
