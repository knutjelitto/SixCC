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
                Declare((dynamic)container, (dynamic)node);
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

        private void DoDeclareClassy(MemberScope scope, A.Decl.Classy decl)
        {
            Resolver[decl].Type = new Type.Classy(Assoc.From(Resolver, decl));
            Resolver[decl].Scope = scope;
            scope.Parent.AddChild(decl);
            DoDeclare(scope, decl);
        }

        private void DoDeclareAssoc(Container scope, A.Decl decl)
        {
            Resolver[decl].Scope = scope;
            scope.Parent.AddChild(decl);
            DoDeclare(scope, decl);
        }

        private void DoDeclare(Container container, A.Decl decl)
        {
            if (decl is A.With.Generics withTypeParams)
            {
                WalkMany(container, withTypeParams.TypeParameters);
            }

            if (decl is A.With.Parameters withParams)
            {
                WalkMany(container, withParams.Parameters);
            }

            if (decl is A.With.Body with)
            {
                Walk(container, with.Body);
            }

            if (decl is A.With.Value withValue && withValue.Value != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveExpression(container, withValue.Value);
                });
            }

            if (decl is A.With.Type withType && withType.Type != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveType(container, withType.Type);
                });
            }

            if (decl is A.With.Extends withExtends && withExtends.Extends != null)
            {
                OnResolve(() =>
                {
                    Resolver.ResolveType(container, withExtends.Extends);
                });
            }

            if (decl is A.With.Satisfies withSatisfies && withSatisfies.Satisfies != null)
            {
                OnResolve(() =>
                {
                    foreach (var type in withSatisfies.Satisfies)
                    {
                        Resolver.ResolveType(container, type);
                    }
                });
            }

            if (decl is A.With.Cases withCases && withCases.Cases != null)
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

        private void Declare(Container parent, A.Decl.Classy node)
        {
            DoDeclareClassy(new ClassyScope(parent), node);
        }

        private void Declare(Container parent, A.Decl.Funcy node)
        {
            DoDeclareAssoc(new FunctionScope(parent), node);

            if (node is A.Decl.Function function)
            {
                OnResolve(() =>
                {
                    Assert(Resolver[function.Type].Type != null);
                    Resolver[node].Type = Resolver[function.Type].Type;
                });
            }
        }

        private void Declare(Container parent, A.TypeParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Default);
            });
        }

        private void Declare(Container parent, A.Decl.DefinitiveParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);

                Resolver[node].Type = Resolver[node.Type].Type;
            });
        }

        private void Declare(Container parent, A.Decl.ValueParameter node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);
                Resolver.ResolveExpression(parent, node.Default);

                Resolver[node].Type = Resolver[node.Type].Type;
            });
        }

        private void Declare(Container parent, A.Decl.Var node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);
                Resolver.ResolveExpression(parent, node.Value);

                if (node.Type != null)
                {
                    Assert(Resolver[node.Type].Type != null);
                    Resolver[node].Type = Resolver[node.Type].Type;
                }
                else
                {
                    Assert(Resolver[node.Value].Type != null);
                    Resolver[node].Type = Resolver[node.Value].Type;
                }
            });
        }

        private void Declare(Container parent, A.Decl.Let node)
        {
            parent.AddChild(node);

            OnResolve(() =>
            {
                Resolver.ResolveType(parent, node.Type);
                Resolver.ResolveExpression(parent, node.Value);

                if (node.Type != null)
                {
                    Assert(Resolver[node.Type].Type != null);
                    Resolver[node].Type = Resolver[node.Type].Type;
                }
                else
                {
                    Assert(Resolver[node.Value].Type != null);
                    Resolver[node].Type = Resolver[node.Value].Type;
                }
            });
        }

        private void Declare(Container parent, A.Decl.Attribute node)
        {
            DoDeclareAssoc(Container.Empty(parent), node);

            OnResolve(() =>
            {
                if (node.Type != null)
                {
                    var type = Resolver[node.Type].Type;
                    Resolver[node].Type = type;
                }
            });
        }

        private void Declare(Container parent, A.Decl.Alias node)
        {
            Resolver[node].Type = new Type.Alias(Assoc.From(Resolver, node));
            DoDeclare(new DeclarationScope(parent), parent.AddChild(node));
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

        private void Declare(MemberScope parent, A.Body.Class node)
        {
            parent.AddChild(node);

            WalkMany(parent.Members, node.Block.Usings);
            WalkMany(parent.Members, node.Block.Statelarations);
        }

        private void Declare(MemberScope parent, A.Body.Interface node)
        {
            parent.AddChild(node);

            WalkMany(parent.Members, node.Block.Usings);
            WalkMany(parent.Members, node.Block.Statelarations);
        }

        private void Declare(Container parent, A.Body.Block node)
        {
            Container content;
            if (parent is MemberScope memberScope)
            {
                content = memberScope.Members;
            }
            else
            {
                content = new BlockScope(parent);
            }
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
