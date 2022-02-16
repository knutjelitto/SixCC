using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    partial class Resolver
    {
        public Type? ResolveType(Container container, A.Type typeNode, bool asTuple = false)
        {
            switch (typeNode)
            {
                case A.Reference node:
                    {
                        return ResolveReference(container, node);
                    }
                case A.Type.Nullable node:
                    {
                        var nullEntity = Module.CoreFindNull(node);

                        if (nullEntity != null)
                        {
                            var @null = new Reference(nullEntity);
                            var type = ResolveType(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Union(@null, type);
                            }
                        }

                        Didnt(node, "nullable");
                        return null;
                    }
                case A.Type.Callable node:
                    {
                        var callable = Module.CoreFindCallable(node);
                        if (callable != null)
                        {
                            var type = ResolveType(container, node.Type);
                            if (type != null)
                            {
                                var arguments = ResolveType(container, node.Arguments, true);
                                if (arguments != null)
                                {
                                    return new Reference(callable, type, arguments);
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
                                    return new Reference(empty!);
                                }
                                var first = types[offset];
                                var rest = tuplize(types, offset + 1);
                                var type = new Type.Union(first, rest);

                                return new Reference(tuple!, type, first, rest);
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
                        return ResolveType(container, node.Types, true);
                    }
                case A.Type.Constructor node:
                    {
                        var type = ResolveType(container, node.Type);

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
                            return new Reference(empty);
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
    }
}
