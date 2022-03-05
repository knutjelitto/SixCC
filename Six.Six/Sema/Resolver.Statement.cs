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
        private void WalkStatement(Scope scope, A.Stmt node)
        {
            Statement((dynamic)scope, (dynamic)node);
        }

        private void Statement(BlockScope container, A.Stmt.Assign node)
        {
            var stmt = container.AddMember(new Stmt.Assign(container, node));
            CurrentFunction.Members.Add(stmt);

            var left = ResolveExpression(container, node.Left);
            var right = ResolveExpression(container, node.Right);

            ResolveLater(() =>
            {
                if (left.Resolved != null && right.Resolved != null)
                {
                    stmt.Left = left.Resolved;
                    stmt.Right = right.Resolved;
                }
                else
                {
                    Assert(false);
                }
            });
        }

        private void Statement(BlockScope container, A.Stmt.Return node)
        {
            var stmt = container.AddMember(new Stmt.Return(container, node));
            CurrentFunction.Members.Add(stmt);

            if (node.Expression != null)
            {
                var result = ResolveExpression(container, node.Expression);

                ResolveLater(() =>
                {
                    if (result.Resolved != null)
                    {
                        var function = CurrentFunction as Decl.Function;
                        if (function != null)
                        {
                            var functionType = ResolveType(function.Result);
                            var returnType = ResolveExprType(result.Resolved);

                            if (ReferenceEquals(functionType, returnType))
                            {
                                stmt.Expr = result.Resolved;
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
        }

        private void Statement(BlockScope container, A.Stmt.Expr node)
        {
            Assert(false);
            container.AddMember(new Statement(container, node));
        }

        private void Statement(BlockScope container, A.Stmt node)
        {
            Assert(false);
            container.AddMember(new Statement(container, node));
        }
    }
}
