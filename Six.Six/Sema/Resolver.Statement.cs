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
        private Stmt WalkStatement(CodeBlock block, A.Stmt node)
        {
            return Statement(block, (dynamic)node);
        }

        private Stmt Statement(CodeBlock block, A.Stmt node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Stmt Statement(CodeBlock block, A.Stmt.If node)
        {
            var ifBlock = block.NewNested();

            var condition = ExpressionConditions(ifBlock, node.Conditions);
            WalkBody(block, node.Then);

            if (node.Else != null)
            {
                WalkBody(block, node.Else);
            }

            Assert(false);
            throw new NotImplementedException();
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Expr node)
        {
            return new Stmt.Expression(
                    node.GetLocation(),
                    block,
                    ResolveExpression(block, node.Expression));
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Assign node)
        {
            return new Stmt.Assign(
                    node.GetLocation(),
                    block,
                    ResolveExpression(block, node.Left),
                    ResolveExpression(block, node.Right));
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Return node)
        {
            return new Stmt.Return(
                    node.GetLocation(),
                    block,
                    node.Expression == null ? null : ResolveExpression(block, node.Expression));
        }
    }
}
