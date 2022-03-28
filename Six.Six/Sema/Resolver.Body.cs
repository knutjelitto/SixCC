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
            FuncyBody(block, (dynamic)node);
        }

        private void FuncyBody(FuncBlock block, A.Body.Block node)
        {
            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    WalkDeclaration(block, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    WalkStatement(block, stmt);
                }
                else
                {
                    Assert(false);
                }
            }
        }

        private void FuncyBody(FuncBlock block, A.Body.Deferred node)
        {
            Assert(block.Funcy.IsAbstract || block.Funcy is Decl.Constructor ctor && ctor.IsNative);

            _ = new Stmt.Unreachable(node.GetLocation(), block);
        }

        private void FuncyBody(FuncBlock block, A.Body.Expr node)
        {
            var delayed = ResolveExpression(block, node.Expression);

            _ = new Stmt.Return(node.Expression.GetLocation(), block, delayed);
        }
    }
}
