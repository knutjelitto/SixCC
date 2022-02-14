using Six.Runtime.Types;
using System;
using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public sealed class Resolver
    {
        private readonly Queue<Action> onResolve = new();

        public Resolver(Module global)
        {
            Module = global;
        }

        public Module Module { get; }

        public void Resolve()
        {
            while (onResolve.Count > 0)
            {
                onResolve.Dequeue()();
            }
        }

        public void OnResolve(Action onResolve)
        {
            this.onResolve.Enqueue(onResolve);
        }

        public Type? Resolve(Container container, A.Type typeNode, bool asTuple = false)
        {
            switch (typeNode)
            {
                case A.Reference node:
                    {
                        var entity = container.Resolve(node.Name.Text);
                        if (entity != null)
                        {
                            if (node.Arguments != null)
                            {
                                var arguments = resolveMany(node.Arguments);
                                if (arguments != null)
                                {
                                    return new Type.Reference(entity, arguments);
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return new Type.Reference(entity);
                            }
                        }
                        didnt(node, $"reference - {node.Name.Text}");
                        return null;
                    }
                case A.Type.Nullable node:
                    {
                        var nullEntity = Module.CoreFindNull();

                        if (nullEntity != null)
                        {
                            var @null = new Type.Reference(nullEntity);
                            var type = Resolve(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Union(@null, type);
                            }
                        }

                        didnt(node, "nullable");
                        return null;
                    }
                case A.Type.Callable node:
                    {
                        var callable = Module.CoreFindCallable();
                        if (callable != null)
                        {
                            var type = Resolve(container, node.Type);
                            if (type != null)
                            {
                                var arguments = Resolve(container, node.Arguments, true);
                                if (arguments != null)
                                {
                                    return new Type.Reference(callable, type, arguments);
                                }
                            }
                        }

                        didnt(node, "callable");
                        return null;
                    }
                case A.Type.Spread node:
                    {
                        var sequential = Module.CoreFindSequential();
                        if (sequential != null)
                        {
                            var type = Resolve(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Sequential(sequential, type);
                            }
                        }

                        didnt(node, "spread");
                        return null;
                    }
                case A.Type.IterableZeroOrMore node:
                    {
                        var nullEntity = Module.CoreFindNull();
                        if (nullEntity == null)
                        {
                            didnt(node, "Null");
                            return null;
                        }
                        var iterable = Module.CoreFindIterable();
                        if (iterable == null)
                        {
                            didnt(node, "Iterable");
                            return null;
                        }
                        var @null = new Type.Reference(nullEntity);
                        var type = Resolve(container, node.Type);
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
                            didnt(node, Module.CoreIterable);
                            return null;
                        }
                        var type = Resolve(container, node.Type);
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
                            didnt(node, Module.CoreSequential);
                            return null;
                        }

                        var type = Resolve(container, node.Type);
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
                            didnt(node, Module.CoreSequence);
                            return null;
                        }
                        var type = Resolve(container, node.Type);
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
                            didnt(node, Module.CoreEmpty);
                            return null;
                        }
                        var type = Resolve(container, node.Type);
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
                            var type = Resolve(container, member);
                            if (type != null)
                            {
                                types.Add(type);
                            }
                        }
                        if (types.Count == node.Count)
                        {
                            return new Type.Intersection(types.ToArray());
                        }

                        didnt(node, "intersection");
                        return null;
                    }
                case A.Type.Types node:
                    {
                        var empty = Module.CoreFindEmpty();
                        if (empty == null)
                        {
                            didnt(node, "Empty not found");
                        }
                        var sequence = Module.CoreFindSequence();
                        if (sequence == null)
                        {
                            didnt(node, "Sequence not found");
                        }
                        var sequential = Module.CoreFindSequential();
                        if (sequential == null)
                        {
                            didnt(node, "Sequence not found");
                        }
                        var tuple = Module.CoreFindTuple();
                        if (tuple == null)
                        {
                            didnt(node, "Tuple not found");
                        }

                        if (asTuple)
                        {
                            var types = resolveMany(node);
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

                        didnt(node, "types");
                        return null;
                    }
                case A.Type.Tuple node:
                    {
                        return Resolve(container, node.Types, true);
                    }
                case A.Type.Sequence node:
                    {
                        var sequence = Module.CoreFindSequence();
                        if (sequence != null)
                        {
                            var type = Resolve(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Sequence(sequence, type);
                            }
                        }

                        didnt(node, "sequence");
                        return null;
                    }
                case A.Type.Constructor node:
                    {
                        var type = Resolve(container, node.Type);

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
                        didnt(node, "empty");
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

            void didnt(A.Type node, string what)
            {
                Module.Add(new Six.Core.Errors.SemanticError(Location.From(node.Tree), $"didn't resolve type: {what}"));
            }

            Type[]? resolveMany(A.Many<A.Type> types)
            {
                var results = new List<Type>();
                foreach (var arg in types)
                {
                    var result = Resolve(container, arg);
                    if (result != null)
                    {
                        results.Add(result);
                    }
                }
                if (results.Count == types.Count)
                {
                    return results.ToArray();
                }
                return null;
            }
        }

        public void Resolve(Container container, A.Expression node)
        {
        }
    }
}
