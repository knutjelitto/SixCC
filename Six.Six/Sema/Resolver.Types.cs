using System;
using Six.Six.Builtins;

using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        public Type? ResolveExprType(Expr.Concrete? expr)
        {
            return ResolveType(expr?.Type);
        }

        public Type? ResolveDeclType(Decl decl)
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
                    if (reference.Decl.ADecl is A.Decl.Primitive primitive)
                    {
                        var name = primitive.Name.Text;

                        Assert(true);

                        var builtin = Builtins.Resolve(name);

                        return builtin;
                    }
                    return ResolveDeclType(reference.Decl);
                }
            }
            return type;
        }

        private Type ResolveType(Scope scope, A.Type tree)
        {
            return DoResolveType(scope, (dynamic)tree);
        }

        private Type DoResolveType(Scope scope, A.Type.Array tree)
        {
            var type = ResolveType(scope, tree.Type);

            return new Type.Array(type);
        }

        private Type DoResolveType(Scope scope, A.Type tree)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Type DoResolveType(Scope scope, A.Reference tree)
        {
            var resolved = scope.Resolve(tree, tree.Name.Text);
            var xxx = ResolveDeclType(resolved);

            if (resolved.ADecl is A.Decl.Primitive primitive)
            {
                var builtin = Builtins.Resolve(primitive.Name.Text);

                return builtin;
            }
            if (xxx != null)
            {
                return xxx;
            }
            return new Type.Reference(this, resolved);
        }
    }
}
