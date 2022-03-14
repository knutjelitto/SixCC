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
            var stmt = container.AddMember(
                new Stmt.Assign(
                    container, 
                    node,
                    ResolveExpression(container, node.Left),
                    ResolveExpression(container, node.Right)));
            CurrentFunction.Members.Add(stmt);
        }

        private void Statement(BlockScope container, A.Stmt.Return node)
        {
            if (CurrentFunction is Decl.Function function)
            {
                var stmt = container.AddMember(new Stmt.Return(
                    container,
                    node,
                    function,
                    node.Expression == null ? null : ResolveExpression(container, node.Expression)));
                function.Members.Add(stmt);
            }
            else
            {
                Assert(false);
            }
        }

        private void Statement(BlockScope container, A.Stmt.Expr node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Statement(BlockScope container, A.Stmt node)
        {
            Assert(false);
            throw new NotImplementedException();
        }
    }
}
