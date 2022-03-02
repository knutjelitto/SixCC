using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Six.Six.Sema;
using A = Six.Six.Ast;

namespace Six.Six.Builtins
{
    public static class Extensions
    {
        public static Expr.Concrete Infix(this Six.Sema.Type.Builtin builtin, A.Reference named, Expr.Delayed left, Expr.Delayed right)
        {
            Assert(left.Resolved != null && right.Resolved != null);
            var concrete = builtin as Builtin ?? throw new InvalidCastException();
            var builder = concrete.Infix(named.Name.Text);
            var primitive = builder(left.Resolved, right.Resolved);
            return primitive;
        }

        public static Expr.Concrete Prefix(this Six.Sema.Type.Builtin builtin, A.Reference named, Expr.Delayed right)
        {
            Assert(right.Resolved != null);
            var concrete = builtin as Builtin ?? throw new InvalidCastException();
            var builder = concrete.Prefix(named.Name.Text);
            var primitive = builder(right.Resolved);
            return primitive;
        }
    }
}
