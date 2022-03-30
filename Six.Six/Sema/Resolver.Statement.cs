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
        private void WalkStatement(FuncBlock block, A.Stmt node)
        {
            Statement(block, (dynamic)node);
        }

        private void Statement(FuncBlock block, A.Stmt node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Statement(FuncBlock block, A.Stmt.Expr node)
        {
            _ = new Stmt.Expression(
                    node.GetLocation(),
                    block,
                    ResolveExpression(block, node.Expression));
        }

        private void Statement(FuncBlock block, A.Stmt.Assign node)
        {
            _ = new Stmt.Assign(
                    node.GetLocation(),
                    block,
                    ResolveExpression(block, node.Left),
                    ResolveExpression(block, node.Right));
        }

        private void Statement(FuncBlock block, A.Stmt.Return node)
        {
            _ = new Stmt.Return(
                    node.GetLocation(),
                    block,
                    node.Expression == null ? null : ResolveExpression(block, node.Expression));
        }
    }
}
