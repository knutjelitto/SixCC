﻿using Six.Six.Instructions;
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

            ScheduleExpr(() =>
            {
                if (left.Resolved != null && right.Resolved != null)
                {
                    stmt.Left = left.Resolved;
                    stmt.Right = right.Resolved;
                }
                else
                {
                    Assert(Module.Errors);
                }
            });
        }

        private void Statement(BlockScope container, A.Stmt.Return node)
        {
            var stmt = container.AddMember(new Stmt.Return(container, node));
            CurrentFunction.Members.Add(stmt);

            if (node.Expression != null)
            {
                var expr = ResolveExpression(container, node.Expression);

                ScheduleExpr(() =>
                {
                    if (expr.Resolved != null)
                    {
                        var function = CurrentFunction as Decl.Function;
                        if (function != null)
                        {
                            var functionType = ResolveType(function.ResultType);
                            var returnType = EvalType(expr.Resolved.Type);

                            if (ReferenceEquals(functionType, returnType))
                            {
                                stmt.Expr = expr.Resolved;
                            }
                            else
                            {
                                Assert(Module.Errors);
                            }
                        }
                        else
                        {
                            Assert(Module.Errors);
                        }
                    }
                    else
                    {
                        Assert(Module.Errors);
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
