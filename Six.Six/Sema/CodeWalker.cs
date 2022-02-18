using Six.Core;
using System;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class CodeWalker
    {
        private CodeWalker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private void OnResolve(Action onResolve)
        {
            Resolver.OnResolve(onResolve);
        }

        public static void Walk(Module module, A.Unit.Code code)
        {
            new CodeWalker(module).CodeUnit(code);
        }

        private void CodeUnit(A.Unit.Code code)
        {
            var @namespace = Module.Open(code.Namespace);

            WalkMany(@namespace, code.Declarations);
        }

        private void Walk(Container container, A.Node? node)
        {
            if (node != null)
            {
                Declare(container, (dynamic)node);
            }
        }

        private void WalkMany(Container container, IEnumerable<A.Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(container, node);
                }
            }
        }

        private void DoDeclare(Container container, A.Decl declaration)
        {
            if (declaration is A.With.Generics withTypeParams)
            {
                WalkMany(container, withTypeParams.TypeParameters);
            }

            if (declaration is A.With.Parameters withParams)
            {
                WalkMany(container, withParams.Parameters);
            }
            else if (declaration is A.Decl.Infix infix)
            {
                Walk(container, infix.Rhs);
            }
            else if (declaration is A.Decl.Prefix prefix)
            {
            }

            if (declaration is A.With.Body with)
            {
                Walk(container, with.Body);
            }

            if (declaration is A.With.Type withType && withType.Type != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveType(container, withType.Type);
                });
            }

            if (declaration is A.With.Result withResult && withResult.Result != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveType(container, withResult.Result);
                });
            }

            if (declaration is A.With.Value withValue && withValue.Value != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveExpression(container, withValue.Value);
                });
            }

            if (declaration is A.With.Extends withExtends && withExtends.Extends != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveType(container, withExtends.Extends);
                });
            }

            if (declaration is A.With.Satisfies withSatisfies && withSatisfies.Satisfies != null)
            {
                OnResolve(() =>
                {
                    foreach (var type in withSatisfies.Satisfies)
                    {
                        Resolver.ResolveType(container, type);
                    }
                });
            }

            if (declaration is A.With.Cases withCases && withCases.Cases != null)
            {
                OnResolve(() =>
                {
                    foreach (var type in withCases.Cases)
                    {
                        Resolver.ResolveType(container, type);
                    }
                });
            }
        }

        private static void Declare(Container parent, A.TreeNode node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Declare(Container parent, A.TypeParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Default);
            });
        }

        private void Declare(Container parent, A.DefinitiveParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);
            });
        }

        private void Declare(Container parent, A.ValueParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);
                Resolver.ResolveExpression(parent, node.Default);
            });
        }

        private void Declare(Container parent, A.Decl.Prefix node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }
        private void Declare(Container parent, A.Decl.Infix node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Primitive node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Constructor node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Var node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Let node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Function node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Class node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Attribute node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Object node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Interface node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Decl.Alias node)
        {
            var content = new DeclarationScope(parent);
            DoDeclare(content, parent.AddChild(node));
        }

        private void Declare(Container parent, A.Stmt.Return node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveExpression(parent, node.Expression);
            });
        }

        private void Declare(Container parent, A.Stmt.Assert node)
        {
            parent.AddChild(node);
        }

        private void Declare(Container parent, A.Stmt.For node)
        {
            parent.AddChild(node);
        }

        private void Declare(Container parent, A.Stmt.If node)
        {
            parent.AddChild(node);
        }

        private void Declare(Container parent, A.Stmt.Expr node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveExpression(parent, node.Expression);
            });
        }

        private void Declare(Container parent, A.Stmt.Assign node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveExpression(parent, node.Left);
                Resolver.ResolveExpression(parent, node.Right);
            });
        }

        private void Declare(Container parent, A.Body.Block node)
        {
            var content = new BlockScope(parent);
            parent.AddChild(node);

            WalkMany(content, node.Statelarations);
        }

        private void Declare(Container parent, A.Body.Value node)
        {
            OnResolve(() =>
            {
                Resolver.ResolveExpression(parent, node.Expression);
            });
        }

        private void Declare(Container parent, A.Body.Deferred node)
        {
        }

        private void Declare(Container parent, A.Body.Builtin node)
        {
        }

        private void Declare(Container parent, A.Node node)
        {
            Assert(false);
        }
    }
}
