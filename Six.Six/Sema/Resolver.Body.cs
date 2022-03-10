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
        private void WalkBody(Scope scope, A.Body node)
        {
            Body((dynamic)scope, (dynamic)node);
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

        private void Body(BlockScope container, A.Body.Deferred node)
        {
        }

        private void Body(BlockScope container, A.Body.Value node)
        {
            var delayed = new Expr.Delayed();

            var value = ResolveExpression(container, node.Expression);

            ScheduleExpr(() =>
            {
                if (value.Resolved != null)
                {
                    delayed.Resolved = value.Resolved;
                }
                else
                {
                    Assert(Module.Errors);
                }
            });
        }

        private void Body(BlockScope container, A.Body.Calc node)
        {
        }
    }
}
