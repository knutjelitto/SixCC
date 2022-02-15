using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {

        public Expression? ResolveExpression(Container container, A.Expression expressionNode)
        {
            var assoc = Ass(expressionNode);
            Assert(assoc == null);
            Assoc.Add(expressionNode, new Attrib(container, expressionNode));

            switch (expressionNode)
            {
                case A.Reference node:
                    return ResolveReference(container, node, (e, t) => new Expression.Reference(e, t));
                //case A.Expression.Call node:
                case A.Expression.Not node:
                    return Unary(node, expr => new Expression.Not(expr));
                case A.Expression.Neg node:
                    return Unary(node, expr => new Expression.Neg(expr));
                case A.Expression.AndThen node:
                    return Binary(node, (left, right) => new Expression.AndThen(left, right));
                case A.Expression.OrElse node:
                    return Binary(node, (left, right) => new Expression.OrElse(left, right));
                case A.Expression.Identical node:
                    return Binary(node, (left, right) => new Expression.Identical(left, right));
                case A.Expression.NotIdentical node:
                    return Binary(node, (left, right) => new Expression.NotIdentical(left, right));
                case A.Expression.Add node:
                    return Binary(node, (left, right) => new Expression.Add(left, right));
                case A.Expression.Sub node:
                    return Binary(node, (left, right) => new Expression.Sub(left, right));
                case A.Expression.Mul node:
                    return Binary(node, (left, right) => new Expression.Mul(left, right));
                case A.Expression.Div node:
                    return Binary(node, (left, right) => new Expression.Div(left, right));
                case A.Expression.Rem node:
                    return Binary(node, (left, right) => new Expression.Rem(left, right));
                default:
                    Didnt(expressionNode, expressionNode.GetType().Name);
                    return null;
            }

            Expression? Unary(A.Expression.Unary node, Func<Expression, Expression> create)
            {
                var expr = ResolveExpression(container, node.Expr);
                if (expr != null)
                {
                    return create(expr);
                }
                return null;
            }

            Expression? Binary(A.Expression.Binary node, Func<Expression, Expression, Expression> create)
            {
                var left = ResolveExpression(container, node.Left);
                if (left != null)
                {
                    var right = ResolveExpression(container, node.Right);
                    if (right != null)
                    {
                        return create(left, right);
                    }
                }
                return null;
            }
        }
    }
}
