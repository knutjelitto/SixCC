using System;

using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class StatementResolver : ResolverCore
    {
        public StatementResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

        public Stmt WalkStatement(CodeBlock block, A.Stmt node)
        {
            return Statement(block, (dynamic)node);
        }

        private Stmt Statement(CodeBlock block, A.Stmt node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Expr node)
        {
            return new Stmt.Expression(
                    node.GetLocation(),
                    block,
                    E.ResolveExpression(block, node.Expression));
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Assign node)
        {
            return new Stmt.Assign(
                    node.GetLocation(),
                    block,
                    E.ResolveExpression(block, node.Left),
                    E.ResolveExpression(block, node.Right));
        }

        private Stmt Statement(CodeBlock block, A.Stmt.Return node)
        {
            return new Stmt.Return(
                    node.GetLocation(),
                    block,
                    node.Expression == null ? null : E.ResolveExpression(block, node.Expression));
        }

        private Stmt Statement(CodeBlock block, A.Stmt.If node)
        {
            var ifBlock = block.NewNested();

            var condition = E.ExpressionConditions(ifBlock, node.Conditions);
            
            B.WalkBody(ifBlock, node.Then);

            CodeBlock? elseBlock = null;
            if (node.Else != null)
            {
                elseBlock = block.NewNested();
                if (node.Else is A.Stmt.If elseIf)
                {
                    elseBlock.Add(WalkStatement(elseBlock, elseIf));
                }
                else
                {
                    B.WalkBody(elseBlock, node.Else);
                }
            }

            return new Stmt.If(node.GetLocation(), block, condition, ifBlock, elseBlock);
        }

        private Stmt Statement(CodeBlock block, A.Stmt.While node)
        {
            var whileBlock = block.NewNested();

            var condition = E.ExpressionConditions(whileBlock, node.Conditions);

            B.WalkBody(whileBlock, node.Block);

            return new Stmt.While(node.GetLocation(), block, condition, whileBlock);
        }

    }
}
