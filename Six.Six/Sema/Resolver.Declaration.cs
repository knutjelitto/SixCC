﻿using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        private void WalkDeclarationMany(Scope scope, IEnumerable<A.Decl>? nodes)
        {
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    WalkDeclaration(scope, node);
                }
            }
        }

        private void WalkDeclaration(Scope scope, A.Decl? node)
        {
            if (node != null)
            {
                Declare((dynamic)scope, (dynamic)node);
            }
        }

        private void Declare(Scope container, A.Node node)
        {
            Assert(false);
        }

        private void Declare(Scope container, A.Decl.Classy node)
        {
            var scope = new ClassyScope(node.Name.Text, container);
            var decl = container.AddMember(new Decl.Classy(scope, node));

            if (node is A.With.Extends extends && extends.Extends != null)
            {
                if (extends.Extends is A.Reference reference)
                {
                    Schedule(() =>
                    {
                        //decl.SetExtends(ResolveType(container, reference));
                    });
                }
                else
                {
                    Assert(false);
                }
            }
            if (node is A.With.Satisfies satisfies && satisfies.Satisfies != null)
            {

            }
            if (node is A.With.Cases cases && cases.Cases != null)
            {

            }
            if (node is A.With.Body body)
            {
                WalkBody(scope.Block, body.Body);
            }
        }

        private void Declare(Scope container, A.Decl.Infix node)
        {
            var funcy = new FuncyScope(node.Name.Text, container);
            var decl = container.AddMember(new Declaration(funcy, node));

            Assert(node.Parameters.Count == 1);

            WalkDeclaration(funcy, node.Parameters[0]);
            WalkBody(funcy.Block, node.Body);

            Schedule(() =>
            {
                var resultType = ResolveType(funcy, node.Type);
                var paramType = ResolveType(funcy, node.Parameters[0].Type);
                decl.Type = new Type.Callable(decl, resultType, paramType);
            });
        }

        private void Declare(Scope container, A.Decl.Function node)
        {
            var funcy = new FuncyScope(node.Name.Text, container);
            var decl = container.AddMember(new Decl.Function(funcy, node));

            Schedule(() => decl.Result = ResolveType(funcy, node.Type));

            uint index = 0;
            foreach (var p in node.Parameters)
            {
                var param = funcy.AddMember(new Decl.Parameter(funcy, p, index++));

                decl.Parameters.Add(param);

                Schedule(() => param.Type = ResolveType(funcy, p.Type));
                if (p is A.With.Default dflt && dflt.Default != null)
                {
                    Schedule(() => param.Default = ResolveExpression(funcy, dflt.Default));
                }
            }

            if (node is A.With.Body body)
            {
                WalkBody(funcy.Block, body.Body);
            }

            if (node is A.With.Generics generics)
            {
                if (generics.TypeParameters != null)
                {
                    Assert(true);
                }
                WalkDeclarationMany(funcy, generics.TypeParameters);
            }
        }


        private void Declare(Scope container, A.Decl.Funcy node)
        {
            var funcy = new FuncyScope(node.Name.Text, container);
            var decl = container.AddMember(new Decl.Funcy(funcy, node));


            if (node is A.With.Type result)
            {
                if (result.Type is A.Reference reference)
                {
                    Schedule(() =>
                    {
                        Assert(true || decl.Type == null);
                        decl.Type = ResolveType(funcy, reference);
                    });
                }
                else
                {
                    Assert(false);
                }

            }

            if (node is A.With.Parameters parameters)
            {
                uint index = 0;
                foreach (var param in parameters.Parameters)
                {
                    decl.Parameters.Add(new Decl.Parameter(funcy, param, index++));
                }
                WalkDeclarationMany(funcy, parameters.Parameters);
            }
            if (node is A.With.Body body)
            {
                WalkBody(funcy.Block, body.Body);
            }

            if (node is A.With.Generics generics)
            {
                if (generics.TypeParameters != null)
                {
                    Assert(true);
                }
                WalkDeclarationMany(funcy, generics.TypeParameters);
            }
        }

        private void Declare(Scope container, A.Decl.Alias node)
        {
            var scope = new DeclarationScope(node.Name.Text, container);
            var decl = container.AddMember(new Declaration(scope, node));

            if (node.Type is A.Reference reference)
            {
                Schedule(() =>
                {
                    decl.Type = ResolveType(scope, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }

        private void Declare(Scope container, A.Decl.Attribute node)
        {
            var scope = new DeclarationScope(node.Name.Text, container);
            var decl = container.AddMember(new Declaration(scope, node));

            if (node.Type is A.Reference reference)
            {
                Schedule(() =>
                {
                    decl.Type = ResolveType(scope, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }

        private void Declare(Scope container, A.Decl.Var node)
        {
            var scope = new DeclarationScope(node.Name.Text, container);
            container.AddMember(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.Decl.Let node)
        {
            var scope = new DeclarationScope(node.Name.Text, container);
            container.AddMember(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.TypeParameters node)
        {
            WalkDeclarationMany(container, node);
        }

        private void Declare(Scope container, A.TypeParameter node)
        {
            var decl = container.AddMember(new Declaration(container, node));
        }

        private void Declare(Scope container, A.Decl.Parameters node)
        {
            WalkDeclarationMany(container, node);
        }

        private void Declare(Scope container, A.Decl.ValueParameter node)
        {
            var decl = container.AddMember(new Declaration(container, node));

            if (node.Type is A.Reference reference)
            {
                Schedule(() =>
                {
                    decl.Type = ResolveType(container, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }
    }
}
