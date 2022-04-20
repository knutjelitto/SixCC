using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Six.Six.Sema;
using A = Six.Six.Ast;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Types
{
    public static class Extensions
    {
        public static Expr Infix(this Type.Builtin builtin, A.Reference named, Expr left, Expr right)
        {
            var concrete = builtin as Builtin ?? throw new InvalidCastException();
            return concrete.Method(named.Name.Text, 2)(new List<Expr> { left, right });
        }

        public static Expr Prefix(this Type.Builtin builtin, A.Reference named, Expr right)
        {
            var concrete = builtin as Builtin ?? throw new InvalidCastException();
            return concrete.Method(named.Name.Text, 1)(new List<Expr> { right });
        }
    }
}
