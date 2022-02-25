using System;
using static System.Formats.Asn1.AsnWriter;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        public Type? ResolveType(Expr expr)
        {
            return ResolveType(expr.Type);
        }

        public Type? ResolveType(Decl decl)
        {
            if (decl is Decl.Classy)
            {
                return decl.Type;
            }
            return ResolveType(decl.Type);
        }

        public Type? ResolveType(Type? type)
        {
            if (type != null)
            {
                if (type is Type.Reference reference)
                {
                    return ResolveType(reference.Decl);
                }
            }
            return type;
        }

        private Decl? FindInScope(Scope scope, string name)
        {
            return scope.Find(name);
        }

        private Type? ResolveType(Scope scope, A.Reference reference)
        {
            var resolved = scope.Resolve(reference.Name.Text);

            if (resolved != null)
            {
                return new Type.Reference(resolved);
            }
            else
            {
                Assert(false);
                return null;
            }
        }
    }
}
