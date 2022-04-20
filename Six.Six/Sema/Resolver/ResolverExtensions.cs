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
        public static string InfixName(this A.Decl.Infix node)
        {
            return node.Name.InfixName();
        }

        public static string InfixName(this A.Expression.OpExpression node)
        {
            return node.Op.Name.InfixName();
        }

        public static string InfixName(this A.Name node)
        {
            return node.Text.InfixName();
        }

        public static string InfixName(this string name)
        {
            return $"infix.{name}";
        }

        public static string PrefixName(this A.Expression.OpExpression node)
        {
            return node.Op.Name.PrefixName();
        }

        public static string PrefixName(this A.Decl.Prefix node)
        {
            return node.Name.PrefixName();
        }
        
        public static string PrefixName(this A.Name node)
        {
            return node.Text.PrefixName();
        }

        public static string PrefixName(this string name)
        {
            return $"prefix.{name}";
        }
    }
}
