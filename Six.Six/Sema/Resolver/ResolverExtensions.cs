using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public static class ResolverExtensions
    {
        private static string InfixName(A.Name node)
        {
            return $"infix.{node.Text}";
        }
        private static string PrefixName(A.Name node)
        {
            return $"prefix.{node.Text}";
        }

        public static string InfixName(this A.Decl.Infix node)
        {
            return InfixName(node.Name);
        }

        public static string InfixName(this A.Expression.OpExpression node)
        {
            return InfixName(node.Op.Name);
        }

        public static string PrefixName(this A.Expression.OpExpression node)
        {
            return PrefixName(node.Op.Name);
        }

        public static string PrefixName(this A.Decl.Prefix node)
        {
            return PrefixName(node.Name);
        }
    }
}
