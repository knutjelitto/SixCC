using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        public void WalkBody(ClassBlock block, A.Body node)
        {
            ClassyBody(block, (dynamic)node);
        }

        private void ClassyBody(ClassBlock block, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void ClassyBody(ClassBlock block, A.Body.Class node)
        {
            foreach (var decl in node.Declarations)
            {
                WalkDeclaration(block, decl);
            }
        }

        public void WalkBody(FuncBlock block, A.Body node)
        {
            WalkBody(block.CodeBlock, (dynamic)node);
        }

        public void WalkBody(CodeBlock block, A.Body node)
        {
            FuncyBody(block, (dynamic)node);
        }

        public void FuncyBody(CodeBlock block, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void FuncyBody(CodeBlock block, A.Body.Block node)
        {
            var stmts = new List<Stmt>();

            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    WalkDeclaration(block, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    stmts.Add(WalkStatement(block, stmt));
                }
                else
                {
                    Assert(false);
                }
            }

            block.Add(new Stmt.Block(node.GetLocation(), block, stmts));
        }

        private void FuncyBody(CodeBlock block, A.Body.Deferred node)
        {
            Assert(
                block.Funcy.IsAbstract ||
                block.Funcy.IsNative ||
                block.Funcy is Decl.Constructor ctor && ctor.IsNative);

            block.Add(new Stmt.Unreachable(node.GetLocation(), block));
        }

        private void FuncyBody(CodeBlock block, A.Body.Expr node)
        {
            var delayed = ResolveExpression(block, node.Expression);

            block.Add(new Stmt.Return(node.Expression.GetLocation(), block, delayed));
        }
    }
}
