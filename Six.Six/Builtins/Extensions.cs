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
        public static Expr Infix(this Six.Sema.Type.Builtin builtin, A.Reference named, Expr left, Expr right)
        {
            var concrete = builtin as BuiltinCore ?? throw new InvalidCastException();
            var builder = concrete.Infix(named.Name.Text);
            var primitive = builder(left, right);
            return primitive;
        }

        public static Expr Prefix(this Six.Sema.Type.Builtin builtin, A.Reference named, Expr right)
        {
            var concrete = builtin as BuiltinCore ?? throw new InvalidCastException();
            var builder = concrete.Prefix(named.Name.Text);
            var primitive = builder(right);
            return primitive;
        }
    }
}
