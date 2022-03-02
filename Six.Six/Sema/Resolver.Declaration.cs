using Six.Core;
using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        private readonly Stack<Decl.Funcy> functions = new();
        private Decl.Funcy CurrentFunction => functions.Peek();

        private IDisposable UseFunction(Decl.Funcy function)
        {
            functions.Push(function);
            return new Disposable(() => functions.Pop());
        }

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
            var scope = new ClassyScope(container, node.Name.Text);
            var decl = container.AddMember(new Decl.Classy(scope, node));

            if (node is A.With.Extends extends && extends.Extends != null)
            {
                if (extends.Extends is A.Reference reference)
                {
                    ResolveLater(() =>
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
            var funcy = new FuncyScope(container, node.Name.Text);
            var decl = container.AddMember(new Decl.Function(funcy, node), InfixName(node));

            Assert(node.Parameters.Count == 1);

            using (UseFunction(decl))
            {
                WalkDeclarationMany(funcy, node.Parameters);
                WalkBody(funcy.Block, node.Body);

                ResolveLater(() =>
                {
                    var resultType = ResolveType(funcy, node.Type);
                    var paramType = ResolveType(funcy, node.Parameters[0].Type);
                    decl.Type = new Type.Callable(decl, resultType, paramType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Prefix node)
        {
            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.AddMember(new Decl.Function(funcy, node), PrefixName(node));

            Assert(node.Parameters.Count == 0);

            using (UseFunction(decl))
            {
                WalkBody(funcy.Block, node.Body);

                ResolveLater(() =>
                {
                    var resultType = ResolveType(funcy, node.Type);
                    decl.Type = new Type.Callable(decl, resultType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Function node)
        {
            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.AddMember(new Decl.Function(funcy, node));

            using (UseFunction(decl))
            {
                ResolveLater(() => decl.Result = ResolveType(funcy, node.Type));

                WalkDeclarationMany(funcy, node.Parameters);

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
        }


        private void Declare(Scope parent, A.Decl.Funcy node)
        {
            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.AddMember(new Decl.Funcy(funcy, node));

            if (node is A.With.Type result)
            {
                if (result.Type is A.Reference reference)
                {
                    ResolveLater(() =>
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
                var index = 0;
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
                ResolveLater(() =>
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
                ResolveLater(() =>
                {
                    decl.Type = ResolveType(scope, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }

        private void Declare(Scope parent, A.Decl.Var node)
        {
            var scope = new DeclarationScope(node.Name.Text, parent);
            parent.AddMember(new Declaration(scope, node));
        }

        private void Declare(Scope parent, A.Decl.Let node)
        {
            var function = CurrentFunction;
            var funcy = function.Container as FuncyScope;

            Assert(funcy != null);

            var decl = parent.AddMember(new Decl.Let(parent, node, function.Parameters.Count + function.Locals.Count));
            function.Locals.Add(decl);

            var value = ResolveExpression(parent, node.Value);

            ResolveLater(() =>
            {
                if (node.Type != null)
                {
                    decl.Type = ResolveType(parent, node.Type);
                    Assert(decl.Type != null);
                }

                if (value.Resolved != null)
                {
                    var valueType = ResolveType(value.Resolved.Type);
                    value.Resolved.FinalType = valueType;

                    var nominalType = ResolveType(decl.Type);

                    if (nominalType != null)
                    {
                        Assert(ReferenceEquals(nominalType, valueType));
                    }
                    else
                    {
                        decl.Type = value.Resolved.Type;
                    }

                    decl.Value = value.Resolved;
                }
                else
                {
                    Assert(false);
                }
            });
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

        private void Declare(Scope parent, A.Decl.ValueParameter node)
        {
            Assert(functions.Count > 0);

            var funcy = parent as FuncyScope;

            Assert(funcy != null);

            var param = funcy.AddMember(new Decl.Parameter(funcy, node, CurrentFunction.Parameters.Count));
            CurrentFunction.Parameters.Add(param);
            ResolveLater(() => param.Type = ResolveType(funcy, node.Type));
            if (node is A.With.Default dflt && dflt.Default != null)
            {
                var dfltValue = ResolveExpression(funcy, dflt.Default);

                ResolveLater(() =>
                {
                    Assert(dfltValue.Resolved != null);
                    param.Default = dfltValue.Resolved;
                });
            }
        }
    }
}
