﻿using System;
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
            Debug.Assert(expr != null && expr.Type != null);
            return ResolveType(expr.Type);
        }

        public Type ResolveDeclType(Decl decl)
        {
            if (decl is Decl.Classy)
            {
                return decl.Type;
            }
            return ResolveType(decl.Type);
        }

        public Type? EvalType(Type? type)
        {
            if (type != null)
            {
                switch (type)
                {
                    case Type.Callable callable:
                        return ResolveType(callable.Result);
                    default:
                        return ResolveType(type);
                }
            }
            return type;
        }

        public Type ResolveType(Type type)
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
                else if (reference.Decl.ADecl is A.Decl.Alias alias)
                {
                    return ResolveType(reference.Decl.Container, alias.Type);
                }
                return ResolveDeclType(reference.Decl);
            }
            return type;
        }

        public Type ResolveType(Scope scope, A.Type tree)
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

        private Type DoResolveType(Scope scope, A.Type.Callable tree)
        {
            var result = ResolveType(scope, tree.Type);
            var parameters = tree.Arguments.Select(type => ResolveType(scope, type));

            return new Type.Callable(result, parameters.ToList());
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
            return new Type.Reference(resolved);
        }
    }
}
