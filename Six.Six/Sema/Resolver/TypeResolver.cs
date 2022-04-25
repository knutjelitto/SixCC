using Six.Core;
using Six.Six.Types;
using System;

using A = Six.Six.Ast;
using Type = Six.Six.Sema.Type;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable  CA1822 // Mark members as static
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class TypeResolver : ResolverCore
    {
        private Stack<InnerResolver> inner = new();
        private InnerResolver Inner => inner.Peek();

        public TypeResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

        public LazyType ResolveTypeLazy(Block parent, A.Type aType)
        {
            return new LazyType(() => ResolveType(parent, aType));
        }

        public LazyType ResolveTypeLazy(Block parent, LazyExpr value, A.Type? aType)
        {
            if (aType == null)
            {
                return new LazyType(() => value.Value.Type);
            }
            return new LazyType(() => ResolveType(parent, aType));
        }

        public Type LowerType(Type type)
        {
            if (type is Type.Declared declared)
            {
                if (declared.Decl.IsNative)
                {
                    return Builtins.Resolve(declared.Decl);
                }
            }

            return type;
        }

        public Builtin Lower(Type type)
        {
            var lower = LowerType(type);

            switch (lower)
            {
                case Builtin builtin:
                    return builtin;
                case Decl.Classy:
                    return Builtins.Address;
                case Type.Callable:
                    return Builtins.TableIndex;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
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
                var super = ResolveType(classy.Parent, extended);

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
                    var type = ResolveType(classy.Block, aType);

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

        private IDisposable UseInner()
        {
            if (inner.Count == 0)
            {
                inner.Push(new InnerResolver(this));

                return new Disposable(() => inner.Pop());
            }

            return new Disposable(() => { });
        }

        public Type ResolveType(Block block, A.Type tree)
        {
            using (UseInner())
            {
                return Inner.ResolveType(block, tree);
            }
        }

        private class InnerResolver
        {
            private HashSet<string> already = new();

            public InnerResolver(TypeResolver outer)
            {
                Outer = outer;
            }

            public TypeResolver Outer { get; }

            public Type ResolveType(Block block, A.Type tree)
            {
                return TypeOf(block, (dynamic)tree);
            }

            private Type TypeOf(Block block, A.Type tree)
            {
                Assert(false);
                throw new NotImplementedException();
            }

            private Type TypeOf(Block block, A.Type.Array tree)
            {
                var type = ResolveType(block, tree.Type);

                return new Type.Array(Outer.Module, type);
            }

            private Type TypeOf(Block block, A.Type.Callable tree)
            {
                var result = ResolveType(block, tree.Type);
                var parameters = tree.Arguments.Select(type => ResolveType(block, type));

                return new Type.Callable(Outer.Module, result, parameters.ToList());
            }

            private Type TypeOf(Block block, A.Reference tree)
            {
                var name = tree.Name.Text;

                var resolved = block.Resolve(tree, name);

                if (resolved is not Type)
                {
                    return ResolveType(block.Parent, tree);
                }

                if (already.Contains(resolved.FullName))
                {
                    throw Outer.Module.Errors.TypeRecursionDetected(tree.GetLocation(), name);
                }

                already.Add(resolved.FullName);


                return resolved.Type;
            }
        }
    }
}
