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

        private Type[] ResolveMany(Container container, A.Many<A.Type> types)
        {
            return types.Select(type => ResolveTypeIntern(container, type)).ToArray();
        }


        private Expression[] ResolveMany(Container container, A.Many<A.Expression> expressions)
        {
            return expressions.Select(expression => ResolveExpressionIntern(container, expression)).ToArray();
        }

        private Type[] ResolveMany(Container container, IEnumerable<A.Type> types)
        {
            return types.Select(type => ResolveTypeIntern(container, type)).ToArray();
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

        private DiagnosticException InternalWhiteExpected(A.TreeNode node)
        {
            return Diagnostic(node, "<internal> expected white scope");
        }

        private InvalidProgramException NoTypeYet(A.TreeNode node, string what)
        {
            return new InvalidProgramException($"type not yet resolved for `{what}´");
        }

        private Type ResolveTypeReference(Container container, A.Reference node)
        {
            var name = node.Name.Text;

            var decl = container.Resolve(node)
                ?? throw Diagnostic(node, $"can't resolve `{name}´");

            var arguments = node.Arguments == null ? null : ResolveMany(container, node.Arguments);

            var type = this[decl].Type ?? throw NoTypeYet(node, name);

            return new Type.Reference(Assoc.From(this, node), type, decl, arguments);
        }

        private Expression ResolveRest(Container scope, A.Reference node, string name, A.Decl referenced)
        {
            var arguments = node.Arguments == null ? null : ResolveMany(scope, node.Arguments);

            if (referenced is A.Decl.Function function)
            {
                Assert(true);

                var result = this[function.Type].Type
                        ?? throw NoTypeYet(function, function.Name.Text);

                var types = ResolveMany(scope, function.Parameters.Select(p => p.Type));

                return new Expression.Callable(Assoc.From(this, function), result, types);
            }
            else if (referenced is A.Decl.Prefix prefix)
            {
                Assert(true);

                var result = this[prefix.Type].Type
                          ?? throw NoTypeYet(prefix.Type, name);

                var types = ResolveMany(scope, prefix.Parameters.Select(p => p.Type!));
                Assert(types.Length == 0);

                return new Expression.Callable(Assoc.From(this, prefix), result, types);
            }
            else if (referenced is A.Decl.Infix infix)
            {
                Assert(true);

                var result = this[infix.Type].Type
                        ?? throw NoTypeYet(infix, infix.Name.Text);

                var types = ResolveMany(scope, infix.Parameters.Select(p => p.Type!));
                Assert(types.Length == 1);

                return new Expression.Callable(Assoc.From(this, infix), result, types);
            }
            else if (referenced is A.Decl.Attribute attribute)
            {
                Assert(true);
                Assert(arguments == null);

                var result = this[attribute.Type].Type
                        ?? throw NoTypeYet(attribute, attribute.Name.Text);

                return new Expression.Attribute(Assoc.From(this, attribute), result);
            }
            else if (referenced is A.Decl.ValueParameter parameter)
            {
                Assert(true);

                var result = this[parameter.Type].Type
                        ?? throw NoTypeYet(parameter, parameter.Name.Text);

                return new Expression.Parameter(Assoc.From(this, parameter), result);
            }
            else if (referenced is A.Decl.Var var)
            {
                Assert(true);

                var value = ResolveExpressionIntern(scope, var.Value);

                var result =
                    var.Type != null 
                    ? this[var.Type].Type ?? throw NoTypeYet(var, var.Name.Text)
                    : value.Type;

                return new Expression.Var(Assoc.From(this, var), result, value);
            }
            else if (referenced is A.Decl.Let let)
            {
                Assert(true);

                var value = ResolveExpressionIntern(scope, let.Value);

                var result =
                    let.Type != null
                    ? this[let.Type].Type ?? throw NoTypeYet(let, let.Name.Text)
                    : value.Type;

                return new Expression.Let(Assoc.From(this, let), result, value);
            }
            else if (referenced is A.Decl.Class klass)
            {
                Assert(true);

                var result = this[klass].Type
                        ?? throw NoTypeYet(klass, klass.Name.Text);

                return new Expression.Callable(Assoc.From(this, klass), result);
            }
            else
            {
                Assert(false);
            }

            throw new NotImplementedException();

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

        private Expression ResolveInfix(WhiteMemberScope white, A.Reference node)
        {
            return ResolveMember(white, node, "_" + node.Name.Text + "_");
        }

        private Expression ResolvePrefix(WhiteMemberScope white, A.Reference node)
        {
            return ResolveMember(white, node, node.Name.Text + "_");
        }
    }
}
