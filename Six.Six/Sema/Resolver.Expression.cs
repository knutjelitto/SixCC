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
        private Expr.Delayed WalkExpression(Scope scope, A.Expression node)
        {
            return Expression(scope, (dynamic)node);
        }

        private Expr.Delayed Expression(Scope container, A.Expression node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr.Delayed Expression(Scope container, A.Expression.Infix node)
        {
            var expr = new Expr.Delayed();

            var left = WalkExpression(container, node.Left);
            var right = WalkExpression(container, node.Right);

            Schedule(() =>
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
                            var call = new Expr.CallMember(left, callable, right);
                            expr.Resolved = call;
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

            return expr;
        }

        private Expr.Delayed Expression(Scope container, A.Reference node)
        {
            var expr = new Expr.Delayed();

            Schedule(() =>
            {
                var decl = container.Resolve(node.Name.Text);

                Assert(decl != null);

                expr.Resolved = WalkReference(decl, decl.ADecl);
            });

            return expr;
        }

        private Expr WalkReference(Decl decl, A.Decl tree)
        {
            switch (tree)
            {
                case A.Decl.ValueParameter:
                    return new Expr.ParameterReference(decl);
                default:
                    Assert(false);
                    break;
            }
            return new Expr.Reference(decl);
        }

        private Expr.Delayed Expression(Scope container, A.Expression.NaturalNumber node)
        {
            var expr = new Expr.Delayed();

            var value = ConvertNatural(node.Text);

            var type = NaturalType(value);

            expr.Resolved = new Expr.Natural(type, value);

            return expr;
        }
    }
}
