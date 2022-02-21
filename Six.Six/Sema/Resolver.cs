using Six.Core;
using Six.Core.Errors;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {
        private readonly Queue<Action> onResolve = new();
        private readonly IdentityDictionary<A.TreeNode, Assoc> scopeAssoc = new();

        public Resolver(Module global)
        {
            Module = global;
        }

        public Module Module { get; }

        public void Resolve()
        {
            while (onResolve.Count > 0)
            {
                var action = onResolve.Dequeue();

                try
                {
                    action();
                }
                catch (InvalidProgramException)
                {
                    onResolve.Enqueue(action);
                }
            }
        }

        public void OnResolve(Action onResolve)
        {
            this.onResolve.Enqueue(onResolve);
        }

        public Assoc this[A.TreeNode node]
        {
            get
            {
                if (!scopeAssoc.TryGetValue(node, out var assoc))
                {
                    assoc = new Assoc(this, node);
                    scopeAssoc.Add(node, assoc);
                }
                return assoc;
            }
        }

        private Type[]? ResolveMany(Container container, A.Many<A.Type>? types)
        {
            if (types != null)
            {
                var results = new List<Type>();
                foreach (var arg in types)
                {
                    var result = ResolveTypeIntern(container, arg);
                    if (result != null)
                    {
                        results.Add(result);
                    }
                }
                if (results.Count == types.Count)
                {
                    return results.ToArray();
                }
            }
            return null;
        }


        private Expression[] ResolveMany(Container container, A.Many<A.Expression> expressions)
        {
            return expressions.Select(expression => ResolveExpressionIntern(container, expression)).ToArray();
        }

        private void Didnt(A.TreeNode node, string what)
        {
            Module.Add(new Core.Errors.SemanticError(Location.From(node), $"didn't resolve {node.GetType().Name}: {what}"));
        }

        private DiagnosticException Diagnostic(A.TreeNode node, string what)
        {
            return new DiagnosticException(
                new SemanticError(Location.From(node), $"resolve {node.GetType().Name}: {what}")
            );
        }

        private DiagnosticException NoTypeYet(A.TreeNode node, string what)
        {
            return Diagnostic(node, $"type not yet resolved for `{what}´XXX");
        }

        private Type ResolveTypeReference(Container container, A.Reference node)
        {
            var name = node.Name.Text;

            var decl = container.Resolve(node)
                ?? throw Diagnostic(node, $"can't resolve `{name}´");

            var arguments = ResolveMany(container, node.Arguments);

            var type = this[decl].Type
                ?? throw NoTypeYet(node, name);

            return new Reference(Assoc.From(this, node), type, decl, arguments);
        }

        private Expression ResolveRest(Container container, A.Reference node, string name, A.Decl decl)
        {
            var arguments = ResolveMany(container, node.Arguments);

            if (decl is A.Decl.Funcy)
            {
                if (decl is A.Decl.Function function)
                {
                    Assert(true);

                    var result = this[function.Type].Type
                            ?? throw NoTypeYet(function, function.Name.Text);

                    var types = new List<Type>();
                    foreach (var parameter in function.Parameters)
                    {
                        var paramtype = this[parameter].Type
                            ?? throw NoTypeYet(parameter, parameter.Name.Text);
                        types.Add(paramtype);
                    }

                    return new Expression.Callable(Assoc.From(this, decl), result, types.ToArray());
                }
                else if (decl is A.Decl.Prefix prefix)
                {
                    Assert(true);

                    var result = this[prefix.Type].Type
                              ?? throw NoTypeYet(prefix.Type, name);

                    return new Expression.Callable(Assoc.From(this, decl), result);
                }
                else if (decl is A.Decl.Infix infix)
                {
                    Assert(false);
                }
                else
                {
                    Assert(false);
                }
            }
            else if (decl is A.Decl.Attribute)
            {
                Assert(true);
            }
            else
            {
                Assert(true);
            }

            var type = this[decl].Type
                ?? throw NoTypeYet(node, name);

            return new Reference(Assoc.From(this, node), type, decl, arguments);

        }

        private Expression ResolveReference(Container container, A.Reference node)
        {
            var name = node.Name.Text;

            var decl = container.Resolve(node)
                ?? throw Diagnostic(node, $"can't resolve `{name}´");

            return ResolveRest(container, node, name, decl);
        }

        private Expression ResolveMember(WhiteMemberScope white, A.Reference node, string? name = null)
        {
            name ??= node.Name.Text;

            var decl = white.Members.Find(name)
                ?? throw Diagnostic(node, $"can't resolve `{name}´ in members");

            return ResolveRest(white, node, name, decl);
        }
    }
}
