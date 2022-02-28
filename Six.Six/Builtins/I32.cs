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
        public Primitive Neg(Expr.Concrete left)
        {
            throw new NotImplementedException();
        }
        public Primitive Not(Expr.Concrete left)
        {
            throw new NotImplementedException();
        }
        public Primitive Add(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
        public Primitive Sub(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
        public Primitive Mul(Expr.Concrete left, Expr.Concrete right)
        {
            Assert(left.Type is Sema.Type.BuiltinReference leftRef && leftRef.Builtin == this);
            Assert(right.Type is Sema.Type.BuiltinReference rightRef && rightRef.Builtin == this);
            if (left is Expr.Natural natural1 && right is Expr.Natural natural2)
            {
                var value = natural1.Value + natural2.Value;
            }
            throw new NotImplementedException();
        }
        public Primitive Div(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
        public Primitive Rem(Expr.Concrete left, Expr.Concrete right)
        {
            throw new NotImplementedException();
        }
    }
}
