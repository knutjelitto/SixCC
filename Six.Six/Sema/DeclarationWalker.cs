using System;
using static System.Formats.Asn1.AsnWriter;
using A = Six.Six.Ast;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class DeclarationWalker
    {
        private DeclarationWalker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        public static void Walk(Module module, A.Unit.Code code)
        {
            new DeclarationWalker(module).CodeUnit(code);
        }

        private void CodeUnit(A.Unit.Code code)
        {
            var @namespace = Module.Open(code.Namespace);

            WalkDeclarationMany(@namespace, code.Declarations);
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

        private void WalkBody(Scope scope, A.Body node)
        {
            Body((dynamic)scope, (dynamic)node);
        }

        private Expr.Delayed WalkExpression(Scope scope, A.Expression node)
        {
            return Expression(scope, (dynamic)node);
        }

        private void WalkStatement(Scope scope, A.Stmt node)
        {
            Statement((dynamic)scope, (dynamic)node);
        }


        private void Declare(Scope container, A.Node node)
        {
            Assert(false);
        }

        private void Declare(Scope container, A.Decl.Classy node)
        {
            var scope = new ClassyScope(container);
            var decl = container.Add(new Decl.Classy(scope, node));

            if (node is A.With.Extends extends && extends.Extends != null)
            {
                if (extends.Extends is A.Reference reference)
                {
                    Resolver.Schedule(() =>
                    {
                        decl.SetExtends(ResolveType(container, reference));
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
            var funcy = new FuncyScope(container);
            var decl = container.Add(new Declaration(funcy, node));

            Assert(node.Parameters.Count == 1);

            WalkDeclaration(funcy, node.Parameters[0]);
            WalkBody(funcy.Block, node.Body);

            Resolver.Schedule(() =>
            {
                if (node.Type is A.Reference result)
                {
                    var resultType = ResolveType(funcy, result);
                    if (resultType != null)
                    {
                        if (node.Parameters[0].Type is A.Reference parameter)
                        {
                            var paramType = ResolveType(funcy, parameter);
                            if (paramType != null)
                            {
                                decl.Type = new Type.Callable(decl, resultType, paramType);
                            }
                            else
                            {
                                Assert(false);
                            }
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }
            });
        }

        private void Declare(Scope container, A.Decl.Funcy node)
        {
            var funcy = new FuncyScope(container);
            var decl = container.Add(new Declaration(funcy, node));

            if (node is A.With.Generics generics)
            {
                if (generics.TypeParameters != null)
                {
                    Assert(true);
                }
                WalkDeclarationMany(funcy, generics.TypeParameters);
            }
            if (node is A.With.Parameters parameters)
            {
                WalkDeclarationMany(funcy, parameters.Parameters);
            }
            if (node is A.With.Body body)
            {
                WalkBody(funcy.Block, body.Body);
            }
            if (node is A.With.Type result)
            {
                if (result.Type is A.Reference reference)
                {
                    Resolver.Schedule(() =>
                    {
                        decl.Type = ResolveType(funcy, reference);
                    });
                }
                else
                {
                    Assert(false);
                }

            }
        }

        private void Declare(Scope container, A.Decl.Alias node)
        {
            var scope = new DeclarationScope(container);
            var decl = container.Add(new Declaration(scope, node));

            if (node.Type is A.Reference reference)
            {
                Resolver.Schedule(() =>
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
            var scope = new DeclarationScope(container);
            var decl = container.Add(new Declaration(scope, node));

            if (node.Type is A.Reference reference)
            {
                Resolver.Schedule(() =>
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
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.Decl.Let node)
        {
            var scope = new DeclarationScope(container);
            container.Add(new Declaration(scope, node));
        }

        private void Declare(Scope container, A.TypeParameters node)
        {
            WalkDeclarationMany(container, node);
        }

        private void Declare(Scope container, A.TypeParameter node)
        {
            var decl = container.Add(new Declaration(container, node));
        }

        private void Declare(Scope container, A.Decl.Parameters node)
        {
            WalkDeclarationMany(container, node);
        }

        private void Declare(Scope container, A.Decl.ValueParameter node)
        {
            var decl = container.Add(new Declaration(container, node));

            if (node.Type is A.Reference reference)
            {
                Resolver.Schedule(() =>
                {
                    decl.Type = ResolveType(container, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }

        private void Declare(Scope container, A.Decl.DefinitiveParameter node)
        {
            var decl = container.Add(new Declaration(container, node));

            if (node.Type is A.Reference reference)
            {
                Resolver.Schedule(() =>
                {
                    decl.Type = ResolveType(container, reference);
                });
            }
            else
            {
                Assert(false);
            }
        }


        private void Body(BlockScope container, A.Body node)
        {
            Assert(false);
        }

        private void Body(BlockScope container, A.Body.Block node)
        {
            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    WalkDeclaration(container, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    WalkStatement(container, stmt);
                }
                else
                {
                    Assert(false);
                }
            }
        }

        private void Body(BlockScope container, A.Body.Builtin node)
        {
        }

        private void Body(BlockScope container, A.Body.Deferred node)
        {
        }

        private void Body(BlockScope container, A.Body.Value node)
        {
        }

        private void Body(BlockScope container, A.Body.Calc node)
        {
        }


        private Expr.Delayed Expression(Scope container, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr.Delayed Expression(Scope container, A.Expression.Infix node)
        {
            var expr = new Expr.Delayed();

            Resolver.Schedule(() =>
            {
                var left = WalkExpression(container, node.Left);
                var right = WalkExpression(container, node.Right);

                Resolver.Schedule(() =>
                {
                    Assert(left.Ok && right.Ok);

                    if (ResolveType(left) is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content)
                    {
                        var name = "_" + node.Op.Name.Text + "_";
                        var infix = content.Block.Find(name);
                        if (infix != null)
                        {
                            var result = ResolveType(infix);
                            if (result is Type.Callable callable)
                            {
                                var call = new Expr.CallMember(classy, callable, right);
                            }
                            else
                            {
                                Assert(false);
                            }
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else
                    {
                        Assert(false);
                    }
                });
            });

            return expr;
        }

        private Expr.Delayed Expression(Scope container, A.Reference node)
        {
            var expr = new Expr.Delayed();

            Resolver.Schedule(() =>
            {
                var decl = container.Resolve(node.Name.Text);

                Assert(decl != null);

                expr.Resolved = new Expr.Reference(decl);
            });

            return expr;
        }

        private Expr.Delayed Expression(Scope container, A.Expression.NaturalNumber node)
        {
            var expr = new Expr.Delayed();

            var value = Resolver.ConvertNatural(node.Text);

            var type = Resolver.NaturalType(value);

            expr.Resolved = new Expr.Natural(type, value);

            return expr;
        }


        private void Statement(BlockScope container, A.Stmt.Return node)
        {
            var stmt = container.Add(new Statement(container, node));

            if (node.Expression != null)
            {
                Resolver.Schedule(() =>
                {
                    WalkExpression(container, node.Expression);
                });
            }
        }

        private void Statement(BlockScope container, A.Stmt node)
        {
            container.Add(new Statement(container, node));
        }

        private Type? ResolveType(Expr expr)
        {
            return ResolveType(expr.Type);
        }

        private Type? ResolveType(Decl decl)
        {
            if (decl is Decl.Classy)
            {
                return decl.Type;
            }
            return ResolveType(decl.Type);
        }

        private Type? ResolveType(Type? type)
        {
            if (type != null)
            {
                if (type is Type.Reference reference)
                {
                    return ResolveType(reference.Decl);
                }
            }
            return type;
        }

        private Decl? FindInScope(Scope scope, string name)
        {
            return scope.Find(name);
        }

        private Type? ResolveType(Scope scope, A.Reference reference)
        {
            var resolved = scope.Resolve(reference.Name.Text);

            if (resolved != null)
            {
                return new Type.Reference(resolved);
            }
            else
            {
                Assert(false);
                return null;
            }
        }
    }
}
