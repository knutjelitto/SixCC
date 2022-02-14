﻿using Six.Core;
using System;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class CodeWalker
    {
        private readonly Stack<Container> into = new();

        private CodeWalker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        public Container Parent => into.Peek();

        private void OnResolve(Action onResolve)
        {
            Resolver.OnResolve(onResolve);
        }

        public static void Walk(Module module, A.Unit.Code code)
        {
            new CodeWalker(module).Walk(code);
        }

        private void Walk(A.Node? node)
        {
            if (node != null)
            {
                Declare((dynamic)node);
            }
        }

        private void WalkMany(IEnumerable<A.Node>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    Walk(node);
                }
            }
        }

        private IDisposable Push(Container container)
        {
            into.Push(container);

            return new Disposable(() => into.Pop());
        }

        private void DoDeclaration(Entity entity)
        {
            using (Push(entity.Container))
            {
                if (entity.Ast is A.With.TypeParameters withTypeParams)
                {
                    WalkMany(withTypeParams.Generics);
                }

                if (entity.Ast is A.With.MultiParameters withMulti)
                {
                    foreach (var parameters in withMulti.MultiParameters)
                    {
                        WalkMany(parameters);
                    }
                }

                if (entity.Ast is A.With.Parameters withParams)
                {
                    WalkMany(withParams.Parameters);
                }

                if (entity.Ast is A.With.Body with)
                {
                    Walk(with.Body);
                }

                if (entity.Ast is A.With.Extends withExtends)
                {
                    if (withExtends.Extends != null)
                    {
                        OnResolve(() =>
                        {
                            Resolver.Resolve(entity.Container, withExtends.Extends);
                        });
                    }
                }

                if (entity.Ast is A.With.Satisfies withSatisfies)
                {
                    if (withSatisfies.Satisfies != null)
                    {
                        OnResolve(() =>
                        {
                            foreach (var type in withSatisfies.Satisfies)
                            {
                                Resolver.Resolve(entity.Container, type);
                            }
                        });
                    }
                }
            }
        }

        private void Declare(A.Unit.Code code)
        {
            using (Push(Module.Open(code.Namespace)))
            {
                WalkMany(code.Declarations);
            }
        }

        private void Declare(A.Generic.TypeParameter node)
        {
            var entity = Parent.AddChild(new Declaration.TypeParameter(node, Container.Empty(Parent)));

            if (node.Default != null)
            {
                OnResolve(() =>
                {
                    Resolver.Resolve(entity.Container, node.Default);
                });
            }
        }

        private void Declare(A.ValueParameter node)
        {
            var entity = Parent.AddChild(new Declaration.Parameter(node, Container.Empty(Parent)));

            if (node.Type != null)
            {
                OnResolve(() =>
                {
                    Resolver.Resolve(entity.Container, node.Type);
                    if (node.Default != null)
                    {
                        Resolver.Resolve(entity.Container, node.Default);
                    }
                });
            }
        }

        private void Declare(A.Declaration node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Any(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Function node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Function(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Class node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Class(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Attribute node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Attribute(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Object node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Object(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Interface node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Interface(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Declaration.Alias node)
        {
            DoDeclaration(Parent.AddChild(new Declaration.Alias(node, new DeclarationScope(Parent))));
        }

        private void Declare(A.Statement.Return node)
        {
            Parent.AddChild(Statement.New(node, Parent));
        }

        private void Declare(A.Statement.Assert node)
        {
            Parent.AddChild(Statement.New(node, Parent));
        }

        private void Declare(A.Statement.For node)
        {
            Parent.AddChild(Statement.New(node, Parent));
        }

        private void Declare(A.Body.Block node)
        {
            var entity = Parent.AddChild(Statement.Block.New(node, new BlockScope(Parent)));

            using (Push(entity.Container))
            {
                WalkMany(node.Statelarations);
            }
        }

        private void Declare(A.Body.Deferred node)
        {
        }

        private void Declare(A.Node node)
        {
            Assert(false);
        }
    }
}
