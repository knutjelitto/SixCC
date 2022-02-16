using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
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

        private Type[]? ResolveMany(Container container, A.Many<A.Type> types)
        {
            var results = new List<Type>();
            foreach (var arg in types)
{
                var result = ResolveType(container, arg);
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

        private void Didnt(A.TreeNode node, string what)
        {
            Module.Add(new Core.Errors.SemanticError(Location.From(node.Tree), $"didn't resolve {node.GetType().Name}: {what}"));
        }

        private Reference? ResolveReference(Container container, A.Reference node)
        {
            var declarations = container.Resolve(node);
            if (declarations.Count == 0)
            {
                Didnt(node, $"`{node.Name.Text}´");
                return null;
            }
            else
            {
                if (node.Arguments != null)
                {
                    var arguments = ResolveMany(container, node.Arguments);
                    if (arguments != null)
                    {
                        return new Reference(declarations, arguments);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return new Reference(declarations, Array.Empty<Type>());
                }
            }
        }
    }
}
