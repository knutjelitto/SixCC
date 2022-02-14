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
                                var arguments = resolve(node.Arguments);
                                if (arguments != null)
                                {
                                    return new Type.Reference(entity, arguments);
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
                        var @null = reference(Module.CoreFindNull());
                        var type = Resolve(container, node.Type);

                        if (@null != null && type != null)
                        {
                            return new Type.Union(@null, type);
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
                                return new Type.Reference(sequential, type);
                            }
                        }

                        didnt(node, "spread");
                        return null;
                    }
                case A.Type.IterableZeroOrMore node:
                    {
                        var iterable = Module.CoreFindIterable();
                        if (iterable != null)
                        {
                            var @null = reference(Module.CoreFindNull());
                            if (@null != null)
                            {
                                var type = Resolve(container, node.Type);
                                if (type != null)
                                {
                                    return new Type.Reference(iterable, type, @null);
                                }
                            }
                        }

                        didnt(node, "iterable*");
                        return null;
                    }
                case A.Type.ZeroOrMore node:
                    {
                        var sequential = Module.CoreFindSequential();
                        if (sequential != null)
                        {
                            var type = Resolve(container, node.Type);
                            if (type != null)
                            {
                                return new Type.Variadic(new Type.Reference(sequential, type));
                            }
                        }

                        didnt(node, "variadic*");
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
                        if (asTuple)
                        {
                            var tuple = Module.CoreFindTuple();
                            if (tuple != null)
                            {
                                var types = node.Select(type => Resolve(container, type)).ToList();
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
                        didnt(node, "tuple");
                        return null;
                    }
                case A.Type.IterableOneOrMore node:
                    {
                        var iterable = Module.CoreFindIterable();
                        var entity = Resolve(container, node.Type);

                        didnt(node, "iterable+");
                        return null;
                    }
                case A.Type.OneOrMore node:
                    {
                        var entity = Resolve(container, node.Type);

                        didnt(node, "variadic+");
                        return null;
                    }
                case A.Type.Sequence node:
                    {
                        var sequence = Module.CoreFindSequence();
                        var type = Resolve(container, node.Type);

                        didnt(node, "sequence");
                        return null;
                    }
                case A.Type.Constructor node:
                    {
                        didnt(node, "constructor");
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
                case A.Type.Nothing node:
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

            Type? reference(Entity? entity, params Type[] arguments)
            {
                if (entity != null)
                {
                    return new Type.Reference(entity, arguments);
                }
                return null;
            }

            Type[]? resolve(A.Many<A.Type> types)
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
