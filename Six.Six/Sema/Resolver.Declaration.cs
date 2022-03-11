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

        private void DeclareClassyBody(Decl.Classy decl, A.Decl.Classy node)
        {
            using (UseMemby(decl))
            {
                WalkBody(decl.Scope.Block, node.Body);
            }
        }

        //**

        private void Declare(Scope parent, A.Decl.Primitive node)
        {
            var decl = new Decl.Primitive(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Scope parent, A.Decl.Class node)
        {
            var decl = new Decl.Class(parent, node);

            ScheduleType(() =>
            {
                if (node.Extends != null)
                {
                    var type = ResolveType(decl.Scope, node.Extends);
                }
                else
                {
                    var basicDecl = Module.CoreFind(node, Names.Core.Basic);
                    var basicType = new Type.Reference(basicDecl);
                }
            });

            DeclareClassyBody(decl, node);
        }

        private void Declare(Scope parent, A.Decl.Interface node)
        {
            var decl = new Decl.Interface(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void Declare(Scope parent, A.Decl.Object node)
        {
            var decl = new Decl.Object(parent, node);

            DeclareClassyBody(decl, node);
        }

        private void DeclareFunction(Decl.Function decl, A.Decl.Function node)
        {
            if (InMemby)
            {
                CurrentMemby.Members.Add(decl);
            }
            else
            {
                Assert(true);
            }
            using (UseMemby(decl))
            {
                WalkDeclarations(decl.Scope, ((A.With.Parameters)node).Parameters);
                WalkBody(decl.Scope.Block, node.Body);

                ScheduleType(() =>
                {
                    var resultType = ResolveType(decl.Scope, node.Type);
                    var paramType = ((A.With.Parameters)node).Parameters.Select(param => ResolveType(decl.Scope, param.Type)).ToList();
                    decl.Result = resultType;
                    decl.Type = new Type.Callable(resultType, paramType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Infix node)
        {
            Assert(node.Parameters.Count == 1);

            DeclareFunction(new Decl.Function(parent, node, InfixName(node)), node);
        }

        private void Declare(Scope parent, A.Decl.Prefix node)
        {
            Assert(node.Parameters.Count == 0);

            DeclareFunction(new Decl.Function(parent, node, PrefixName(node)), node);
        }

        private void Declare(Scope parent, A.Decl.Function node)
        {
            Assert(node.Parameters.Count >= 0);

            DeclareFunction(new Decl.Function(parent, node, null), node);
        }

        private void DeclareSelf(Decl.Funcy funcy, A.Decl.Funcy aFuncy, Decl.Classy classy)
        {
            var self = new Decl.SelfParameter(funcy.Scope, aFuncy, 0);
            self.Type = new Type.Reference(classy);
            funcy.Scope.Declare(self, Names.Core.SelfValue);
            funcy.Parameters.Add(self);
        }

        private void Declare(Scope parent, A.Decl.Constructor node)
        {
            Assert(InClassy);

            var decl = new Decl.Constructor(parent, node);

            var classy = CurrentMemby as Decl.Classy;
            Assert(classy != null);

            CurrentMemby.Members.Add(decl);

            using (UseMemby(decl))
            {

                DeclareSelf(decl, decl.AFuncyDecl, classy);
                WalkDeclarations(decl.Scope, ((A.With.Parameters)node).Parameters);
                WalkBody(decl.Scope.Block, node.Body);

                ScheduleType(() =>
                {
                    var resultType = ResolveDeclType(classy);
                    Assert(resultType != null);
                    var paramType = ((A.With.Parameters)node).Parameters.Select(param => ResolveType(decl.Scope, param.Type)).ToList();
                    decl.Type = new Type.Callable(resultType, paramType);
                });
            }
        }

        private void Declare(Scope parent, A.Decl.Alias node)
        {
            var decl = new Decl.Alias(parent, node);

            ScheduleType(() =>
            {
                decl.Type = ResolveType(decl.Scope, node.Type);
            });
        }

        private void Declare(BlockScope parent, A.Decl.Attribute node)
        {
            var decl = parent.Declare(new Decl.Attribute(parent, node));

            if (InMemby)
            {
                CurrentMemby.Members.Add(decl);
            }
            else
            {
                Assert(true);
            }

            var body = WalkBody(parent, node.Body);
            if (body is Body.Value)
            {
                Assert(true);
            }

            ScheduleType(() =>
            {
                decl.Type = ResolveType(parent, node.Type);
            });
        }

        private void Declare(Scope parent, A.Decl.Var node)
        {
            var function = CurrentFunction;
            
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
                    var valueType = ResolveType(value.Resolved.Type);
                    value.Resolved.Type = valueType;

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

        private void Declare(Scope parent, A.Decl.Let node)
        {
            var function = CurrentFunction;

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
                    var valueType = ResolveType(value.Resolved.Type);
                    value.Resolved.Type = valueType;

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
                    Assert(Module.Errors);
                }
            });
        }

        private void Declare(Scope container, A.Decl.TypeParameters node)
        {
            WalkDeclarations(container, node);
        }

        private void Declare(Scope container, A.Decl.TypeParameter node)
        {
            var decl = container.Declare(new Decl.TypeParameter(container, node));
        }

        private void Declare(Scope container, A.Decl.Parameters node)
        {
            WalkDeclarations(container, node);
        }

        private void Declare(Scope parent, A.Decl.ValueParameter node)
        {
            var function = CurrentFunction;
            var scope = function.Scope;

            var param = scope.Declare(new Decl.Parameter(scope, node, function.Parameters.Count));
            function.Parameters.Add(param);
            
            ScheduleType(() =>
            {
                param.Type = ResolveType(scope, node.Type);
            });

            if (node.Default != null)
            {
                var dfltValue = ResolveExpression(scope, node.Default);

                ScheduleExpr(() =>
                {
                    Assert(dfltValue.Resolved != null);
                    param.Default = dfltValue.Resolved;
                });
            }
        }
    }
}
