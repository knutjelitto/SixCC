using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    partial class Resolver
    {
        private readonly IdentityDictionary<A.TreeNode, Type> types = new();

        private Type? TypeOf(A.TreeNode tree)
        {
            if (types.TryGetValue(tree, out var type))
            {
                return type;
            }
            return null;
        }

        public void ResolveType(Container container, A.Type? typeNode)
        {
            if (typeNode == null)
            {
                return;
            }

            var type = ResolveTypeIntern(container, typeNode);

            if (type != null)
            {
                Assert(!types.ContainsKey(typeNode));

                types.Add(typeNode, type);
            }
        }

        private Type? ResolveTypeIntern(Container container, A.Type typeNode, bool asTuple = false)
        {
            switch (typeNode)
            {
                case A.Reference node:
                    {
                        return ResolveReference(container, node);
                    }
                case A.Type.Nullable node:
                    {
                        var @null = ResolveInCore(node, Module.CoreNull);
                        var type = ResolveTypeIntern(container, node.Type);

                        if (@null != null && type != null)
                        {
                            return new Type.Union(@null, type);
                        }
                        return null;
                    }
                case A.Type.Callable node:
                    {
                        var callable = Module.CoreFindCallable(node);
                        if (callable != null)
                        {
                            var type = ResolveTypeIntern(container, node.Type);
                            if (type != null)
                            {
                                var arguments = ResolveTypeIntern(container, node.Arguments, true);
                                if (arguments != null)
                                {
                                    return new Reference(node, callable, type, arguments);
                                }
                            }
                        }

                        Didnt(node, "callable");
                        return null;
                    }
                case A.Type.Intersection node:
                    {
                        var types = ResolveMany(container, node);

                        if (types != null)
                        {
                            return new Type.Intersection(types.ToArray());
                        }

                        Didnt(node, "intersection");
                        return null;
                    }
                case A.Type.Union node:
                    {
                        var types = ResolveMany(container, node);

                        if (types != null)
                        {
                            return new Type.Union(types.ToArray());
                        }

                        Didnt(node, "union");
                        return null;
                    }
                case A.Type.Types node:
                    {
                        var empty = Module.CoreFindEmpty(node);
                        if (empty == null)
                        {
                            Didnt(node, "Empty not found");
                        }
                        var sequence = Module.CoreFindSequence(node);
                        if (sequence == null)
                        {
                            Didnt(node, "Sequence not found");
                        }
                        var sequential = Module.CoreFindSequential(node);
                        if (sequential == null)
                        {
                            Didnt(node, "Sequence not found");
                        }
                        var tuple = Module.CoreFindTuple(node);
                        if (tuple == null)
                        {
                            Didnt(node, "Tuple not found");
                        }

                        if (asTuple)
                        {
                            var types = ResolveMany(container, node);
                            if (types != null)
                            {
                                return tuplize(types, 0);
                            }

                            Type tuplize(Type[] types, int offset)
                            {
                                if (offset == types.Length)
                                {
                                    return new Reference(node, empty!);
                                }
                                var first = types[offset];
                                var rest = tuplize(types, offset + 1);
                                var type = new Type.Union(first, rest);

                                return new Reference(node, tuple!, type, first, rest);
                            }
                        }
                        else
                        {

                        }

                        Didnt(node, "types");
                        return null;
                    }
                case A.Type.Tuple node:
                    {
                        return ResolveTypeIntern(container, node.Types, true);
                    }
                case A.Type.Constructor node:
                    {
                        var type = ResolveTypeIntern(container, node.Type);

                        if (type != null)
                        {
                            return type;
                        }
                        return null;
                    }
                case A.Type.Empty node:
                    {
                        var empty = Module.CoreFindEmpty(node);
                        if (empty != null)
                        {
                            return new Reference(node, empty);
                        }
                        Didnt(node, "empty");
                        return null;
                    }
                case A.Type.Nothing:
                    {
                        return new Type.Nothing();
                    }
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private Reference? ResolveInCore(A.TreeNode node, string type)
        {
            var found = Module.CoreFind(node, type);
            if (found != null && found.Count == 1)
            {
                return new Reference(node, found);
            }
            Didnt(node, $"must be in core: `{type}´");
            return null;
        }
    }
}
