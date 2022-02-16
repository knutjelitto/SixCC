using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {
        public ITyped? ResolveExpression(Container container, A.Expression expressionNode)
        {
            switch (expressionNode)
            {
                case A.Expression.Call node:
                    {
                        var expr = ResolveExpression(container, node.Expr);
                        if (expr != null)
                        {
                            var args = new List<ITyped>();
                            foreach (var arg in node.Arguments)
                            {
                                var resolved = ResolveExpression(container, arg);
                                if (resolved != null)
                                {
                                    args.Add(resolved);
                                }
                            }
                            if (args.Count == node.Arguments.Count)
                            {
                                return new ITyped.Call(expr, args.ToArray());
                            }
                        }
                        Didnt(expressionNode, expressionNode.GetType().Name);
                        return null;
                    }
                case A.Reference node:
                    {
                        return ResolveReference(container, node);
                    }
                case A.Expression.Prefix node:
                    {
                        return Prefix(node, expr => new ITyped.Prefix(expr));
                    }
                case A.Expression.Infix node:
                    {
                        return Infix(node, (left, right) => new ITyped.Infix(left, right));
                    }
                default:
                    Didnt(expressionNode, expressionNode.GetType().Name);
                    return null;
            }

            ITyped? Prefix(A.Expression.IPrefix node, Func<ITyped, ITyped> create)
            {
                var expr = ResolveExpression(container, node.Expr);
                if (expr != null)
                {
                    return create(expr);
                }
                return null;
            }

            ITyped? Infix(A.Expression.IInfix node, Func<ITyped, ITyped, ITyped> create)
            {
                var declarations = container.Resolve(node.Op);
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
