using System;

using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable  CA1822 // Mark members as static
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class TypeResolver : ResolverCore
    {
        public TypeResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

        public Decl.Class? ResolveExtends(Decl.Classy classy)
        {
            if (classy is Decl.Interface)
            {
                return null;
            }
            else if (classy.FullName == Names.Core.CoreAnything)
            {
                return null;
            }
            else if (classy.AClassy is A.With.Extends extends && extends.Extends is A.Type extended)
            {
                var super = ResolveType(classy.Block.Head, extended);

                if (super is Decl.Class superClass)
                {
                    return superClass;
                }
                else
                {
                    // super must be a class
                    Assert(false);
                    throw new InvalidOperationException();
                }
            }
            else if (classy.FullName == Names.Core.CoreAnything)
            {
                return null;
            }
            else
            {
                return Module.CoreFindClass(classy.Location, Names.Core.Basic);
            }
        }

        public List<Decl.Interface> ResolveSatisfies(Decl.Classy classy)
        {
            var list = new List<Decl.Interface>();

            if (classy.AClassy.Satisfies is A.Type.Types aTypes)
            {
                foreach (var aType in aTypes)
                {
                    var type = ResolveType(classy.Block.Head, aType);

                    if (type is Decl.Interface iface)
                    {
                        list.Add(iface);
                    }
                    else
                    {
                        throw Errors.MustBeAnInterface(aType);
                    }
                }
            }


            return list;
        }

        public Type ResolveDeclType(Decl decl)
        {
            if (decl is Decl.Object @object && @object.Extends is Decl.Class extends)
            {
                return ResolveDeclType(extends);
            }
            if (decl is Decl.Classy)
            {
                return decl.Type;
            }
            return ResolveType(decl.Type);
        }

        public Type ResolveType(Type type)
        {
            if (type is Type.AliasReference alias)
            {
                return ResolveType(alias.Alias.Type);

            }
            if (type is Decl.Classy classy)
            {
                return ResolveDeclType(classy);
            }

            return type;
        }

        public Type LowerType(Type type)
        {
            var resolved = ResolveType(type);

            if (resolved is Type.Declared declared)
            {
                if (declared.Decl.IsNative)
                {
                    return Builtins.Resolve(declared.Decl);
                }
            }

            return resolved;
        }

        public Type ResolveType(Scope scope, A.Type tree)
        {
            return DoResolveType(scope, (dynamic)tree);
        }

        private Type DoResolveType(Scope scope, A.Type tree)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Type DoResolveType(Scope scope, A.Type.Array tree)
        {
            var type = ResolveType(scope, tree.Type);

            return new Type.Array(Module, type);
        }

        private Type DoResolveType(Scope scope, A.Type.Callable tree)
        {
            var result = ResolveType(scope, tree.Type);
            var parameters = tree.Arguments.Select(type => ResolveType(scope, type));

            return new Type.Callable(Module, result, parameters.ToList());
        }

        private Type DoResolveType(Scope scope, A.Reference tree)
        {
            var resolved = scope.Resolve(tree, tree.Name.Text);
            if (resolved is not Type)
            {
                return ResolveType(scope.Parent, tree);
            }
            else if (resolved.Type is Type.AliasReference)
            {
                Assert(false);
            }

            return ResolveDeclType(resolved);
        }
    }
}
