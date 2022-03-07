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

        private IDisposable UseFuncy(Decl.Funcy function)
        {
            functions.Push(function);
            return new Disposable(() => functions.Pop());
        }

        private void WalkDeclarations(Scope scope, IEnumerable<A.Decl>? nodes)
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

        private void DeclareClassy(ClassyScope scope, Decl.Classy decl, A.Decl.Classy node)
        {
            if (node is A.With.Body body)
            {
                WalkBody(scope.Block, body.Body);
            }
        }

        //**

        private void Declare(Scope parent, A.Decl.Primitive node)
        {
            var scope = new ClassyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Primitive(scope, node));

            DeclareClassy(scope, decl, node);
        }

        private void Declare(Scope parent, A.Decl.Class node)
        {
            var scope = new ClassyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Class(scope, node));

            DeclareClassy(scope, decl, node);
        }

        private void Declare(Scope parent, A.Decl.Interface node)
        {
            var scope = new ClassyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Interface(scope, node));

            DeclareClassy(scope, decl, node);
        }

        private void Declare(Scope parent, A.Decl.Object node)
        {
            var scope = new ClassyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Object(scope, node));

            DeclareClassy(scope, decl, node);
        }

        private void Declare(Scope container, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            var funcy = new FuncyScope(container, node.Name.Text);
            var decl = container.Declare(new Decl.Function(funcy, node), InfixName(node));

            using (UseFuncy(decl))
            {
                WalkDeclarations(funcy, node.Parameters);
                WalkBody(funcy.Block, node.Body);

                ScheduleType(() =>
                {
                    var resultType = ResolveType(funcy, node.Type);
                    var paramType = ResolveType(funcy, node.Parameters[0].Type);
                    decl.Type = new Type.Callable(this, decl, resultType, paramType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Function(funcy, node), PrefixName(node));

            using (UseFuncy(decl))
            {
                WalkBody(funcy.Block, node.Body);

                ScheduleType(() =>
                {
                    var resultType = ResolveType(funcy, node.Type);
                    decl.Type = new Type.Callable(this, decl, resultType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Constructor node)
        {
            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Constructor(funcy, node));

            using (UseFuncy(decl))
            {
                WalkDeclarations(funcy, node.Parameters);
                WalkBody(funcy.Block, node.Body);
            }
        }

        private void Declare(Scope parent, A.Decl.Function node)
        {
            var funcy = new FuncyScope(parent, node.Name.Text);
            var decl = parent.Declare(new Decl.Function(funcy, node));

            using (UseFuncy(decl))
            {
                WalkDeclarations(funcy, node.Parameters);
                WalkBody(funcy.Block, node.Body);
                ScheduleType(() =>
                {
                    decl.Result = ResolveType(funcy, node.Type);
                    var parameterType = CurrentFunction.Parameters.Select(param => param.Type!);
                    decl.Type = new Type.Callable(this, decl, decl.Result, parameterType.ToArray());
                });
            }
        }

        private void Declare(Scope container, A.Decl.Alias node)
        {
            var scope = new DeclarationScope(node.Name.Text, container);
            var decl = container.Declare(new Decl.Alias(scope, node));

            ScheduleType(() =>
            {
                decl.Type = ResolveType(scope, node.Type);
            });
        }

        private void Declare(Scope parent, A.Decl.Attribute node)
        {
            var scope = new DeclarationScope(node.Name.Text, parent);
            var decl = parent.Declare(new Decl.Attribute(scope, node));

            ScheduleType(() =>
            {
                decl.Type = ResolveType(scope, node.Type);
            });
        }

        private void Declare(Scope parent, A.Decl.Var node)
        {
            var function = CurrentFunction;
            var funcy = function.FuncyScope();
            
            var decl = parent.Declare(new Decl.Var(parent, node, function.Parameters.Count + function.Locals.Count));
            function.Locals.Add(decl);
            function.Members.Add(decl);

            if (node.Type != null)
            {
                ScheduleType(() =>
                {
                    decl.Type = ResolveType(parent, node.Type);
                });
            }

            var value = ResolveExpression(parent, node.Value);

            ScheduleExpr(() =>
            {
                if (value.Resolved != null)
                {
                    var valueType = ResolveType(value.Resolved.NominalType);
                    value.Resolved.Type = valueType;

                    var nominalType = ResolveType(decl.Type);

                    if (nominalType != null)
                    {
                        Assert(ReferenceEquals(nominalType, valueType));
                    }
                    else
                    {
                        decl.Type = value.Resolved.NominalType;
                    }

                    decl.Value = value.Resolved;
                }
                else
                {
                    Assert(false);
                }
            });
        }

        private void Declare(Scope parent, A.Decl.Let node)
        {
            var function = CurrentFunction;
            var funcy = function.FuncyScope();

            var decl = parent.Declare(new Decl.Let(parent, node, function.Parameters.Count + function.Locals.Count));
            function.Locals.Add(decl);
            function.Members.Add(decl);

            if (node.Type != null)
            {
                ScheduleType(() =>
                {
                    decl.Type = ResolveType(parent, node.Type);
                });
            }

            var value = ResolveExpression(parent, node.Value);

            ScheduleExpr(() =>
            {
                if (value.Resolved != null)
                {
                    var valueType = ResolveType(value.Resolved.NominalType);
                    value.Resolved.Type = valueType;

                    var nominalType = ResolveType(decl.Type);

                    if (nominalType != null)
                    {
                        Assert(ReferenceEquals(nominalType, valueType));
                    }
                    else
                    {
                        decl.Type = value.Resolved.NominalType;
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
            WalkDeclarations(container, node);
        }

        private void Declare(Scope container, A.TypeParameter node)
        {
            var decl = container.Declare(new Declaration(container, node));
        }

        private void Declare(Scope container, A.Decl.Parameters node)
        {
            WalkDeclarations(container, node);
        }

        private void Declare(Scope parent, A.Decl.ValueParameter node)
        {
            var function = CurrentFunction;
            var funcy = function.FuncyScope();

            var param = funcy.Declare(new Decl.Parameter(funcy, node, CurrentFunction.Parameters.Count));
            function.Parameters.Add(param);
            
            ScheduleType(() =>
            {
                param.Type = ResolveType(funcy, node.Type);
            });

            if (node.Default != null)
            {
                var dfltValue = ResolveExpression(funcy, node.Default);

                ScheduleExpr(() =>
                {
                    Assert(dfltValue.Resolved != null);
                    param.Default = dfltValue.Resolved;
                });
            }
        }
    }
}
