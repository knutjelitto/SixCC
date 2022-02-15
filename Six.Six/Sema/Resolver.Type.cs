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
                        return ResolveReference(container, node, (e, t) => new Type.Reference(e, t));
                    }
                case A.Type.Nullable node:
                    {
                        var nullEntity = Module.CoreFindNull();

                        if (nullEntity != null)
                        {
                            var @null = new Type.Reference(nullEntity);
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
                        var callable = Module.CoreFindCallable();
                        if (callable != null)
                        {
                            var type = ResolveType(container, node.Type);
                            if (type != null)
                            {
                                var arguments = ResolveType(container, node.Arguments, true);
                                if (arguments != null)
                                {
                                    return new Type.Reference(callable, type, arguments);
                                }
                            }
                        }

                        Didnt(node, "callable");
                        return null;
                    }
                case A.Type.Spread node:
                    {
                        var sequential = Module.CoreFindSequential();
                        if (sequential != null)
                        {
                            var type = ResolveType(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Sequential(sequential, type);
                            }
                        }

                        Didnt(node, "spread");
                        return null;
                    }
                case A.Type.IterableZeroOrMore node:
                    {
                        var nullEntity = Module.CoreFindNull();
                        if (nullEntity == null)
                        {
                            Didnt(node, "Null");
                            return null;
                        }
                        var iterable = Module.CoreFindIterable();
                        if (iterable == null)
                        {
                            Didnt(node, "Iterable");
                            return null;
                        }
                        var @null = new Type.Reference(nullEntity);
                        var type = ResolveType(container, node.Type);
                        if (type != null)
                        {
                            return new Type.Reference(iterable, type, @null);
                        }

                        return null;
                    }
                case A.Type.IterableOneOrMore node:
                    {
                        var iterable = Module.CoreFindIterable();
                        if (iterable == null)
                        {
                            Didnt(node, Module.CoreIterable);
                            return null;
                        }
                        var type = ResolveType(container, node.Type);
                        if (type != null)
                        {
                            return new Type.Reference(iterable, type, new Type.Nothing());
                        }

                        return null;
                    }
                case A.Type.ZeroOrMore node:
                    {
                        var sequential = Module.CoreFindSequential();
                        if (sequential == null)
                        {
                            Didnt(node, Module.CoreSequential);
                            return null;
                        }

                        var type = ResolveType(container, node.Type);
                        if (type != null)
                        {
                            return new Type.Variadic(new Type.Sequential(sequential, type));
                        }

                        return null;
                    }
                case A.Type.OneOrMore node:
                    {
                        var sequence = Module.CoreFindSequence();
                        if (sequence == null)
                        {
                            Didnt(node, Module.CoreSequence);
                            return null;
                        }
                        var type = ResolveType(container, node.Type);
                        if (type != null)
                        {
                            return new Type.Variadic(new Type.Sequence(sequence, type));
                        }

                        return null;
                    }
                case A.Type.Defaulted node:
                    {
                        var empty = Module.CoreFindEmpty();
                        if (empty == null)
                        {
                            Didnt(node, Module.CoreEmpty);
                            return null;
                        }
                        var type = ResolveType(container, node.Type);
                        if (type != null)
                        {
                            return new Type.Defaulted(new Type.Reference(empty), type);
                        }
                        return null;
                    }
                case A.Type.Intersection node:
                    {
                        var types = new List<Type>();

                        foreach (var member in node)
                        {
                            var type = ResolveType(container, member);
                            if (type != null)
                            {
                                types.Add(type);
                            }
                        }
                        if (types.Count == node.Count)
                        {
                            return new Type.Intersection(types.ToArray());
                        }

                        Didnt(node, "intersection");
                        return null;
                    }
                case A.Type.Types node:
                    {
                        var empty = Module.CoreFindEmpty();
                        if (empty == null)
                        {
                            Didnt(node, "Empty not found");
                        }
                        var sequence = Module.CoreFindSequence();
                        if (sequence == null)
                        {
                            Didnt(node, "Sequence not found");
                        }
                        var sequential = Module.CoreFindSequential();
                        if (sequential == null)
                        {
                            Didnt(node, "Sequence not found");
                        }
                        var tuple = Module.CoreFindTuple();
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
                                    return new Type.Reference(empty!);
                                }
                                var first = types[offset];
                                if (first is Type.Variadic variadic)
                                {
                                    Assert(offset + 1 == types.Length);
                                    return variadic.Type;
                                }
                                else
                                {
                                    var rest = tuplize(types, offset + 1);
                                    var type = new Type.Union(first, rest);

                                    return new Type.Reference(tuple!, type, first, rest);
                                }
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
                case A.Type.Sequence node:
                    {
                        var sequence = Module.CoreFindSequence();
                        if (sequence != null)
                        {
                            var type = ResolveType(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Sequence(sequence, type);
                            }
                        }

                        Didnt(node, "sequence");
                        return null;
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
                        var empty = Module.CoreFindEmpty();
                        if (empty != null)
                        {
                            return new Type.Reference(empty);
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
