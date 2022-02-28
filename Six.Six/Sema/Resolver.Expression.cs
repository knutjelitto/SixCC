using Six.Six.Instructions;
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
        private string InfixName(A.Expression.OpExpression node)
        {
            return "_" + node.Op.Name.Text + "_";
        }

        private Expr.Delayed ResolveExpression(Scope scope, A.Expression node)
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

            var left = ResolveExpression(container, node.Left);
            var right = ResolveExpression(container, node.Right);

            Schedule(() =>
            {
                if (left.Resolved != null && right.Resolved != null)
                {
                    if (ResolveType(left.Resolved) is Type.Reference reference &&
                        reference.Decl is Decl.Classy classy &&
                        classy.Container is ContentScope content)
                    {
                        var infix = content.Block.Find(node.Op, InfixName(node));
                        var result = ResolveType(infix);
                        if (result is Type.Callable callable)
                        {
                            expr.Resolved = new Expr.CallMember(left, callable, right);
                        }
                        else
                        {
                            Assert(false);
                        }
                    }
                    else if (ResolveType(left.Resolved) is Type.BuiltinReference builtin)
                    {
                        var builder = builtin.Builtin.Infix(node.Op.Name.Text);
                        var primitive = builder(left.Resolved, right.Resolved);
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

        private Expr.Delayed Expression(Scope container, A.Expression.NaturalNumber tree)
        {
            var expr = new Expr.Delayed();

            var value = ConvertNatural(tree.Text);

            var type = NaturalType(tree, value);

            expr.Resolved = new Expr.Natural(type, value);

            return expr;
        }

        private Expr.Delayed Expression(Scope container, A.Reference tree)
        {
            var expr = new Expr.Delayed();

            Schedule(() =>
            {
                expr.Resolved = WalkReference(container.Resolve(tree, tree.Name.Text));
            });

            return expr;
        }

        private Expr.Concrete WalkReference(Decl decl)
        {
            switch (decl)
            {
                case Decl.Parameter node:
                    var insn = Insn.Local.Get(node.Index);
                    return new Expr.ParameterReference(decl);
                default:
                    Assert(false);
                    break;
            }
            return new Expr.Reference(decl);
        }
    }
}
