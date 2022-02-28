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

        private void Statement(BlockScope container, A.Stmt.Return node)
        {
            var stmt = container.AddMember(new Stmt.Return(container, node));

            if (node.Expression != null)
            {
                Schedule(() => stmt.Expr = ResolveExpression(container, node.Expression));
            }
        }

        private void Statement(BlockScope container, A.Stmt node)
        {
            Assert(false);
            container.AddMember(new Statement(container, node));
        }
    }
}
