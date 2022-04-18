using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Sema
{
    public class BodyResolver : ResolverCore
    {
        public BodyResolver(Module module, Resolver resolver)
            : base(module, resolver)
        {
        }

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
                D.WalkDeclaration(block, decl);
            }
        }

        public void WalkBody(FuncBlock block, A.Body node)
        {
            WalkBody(block.CodeBlock, node);
        }

        public void WalkBody(CodeBlock block, A.Body node)
        {
            FuncyBody(block, (dynamic)node);
        }

        private void FuncyBody(CodeBlock block, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void FuncyBody(CodeBlock block, A.Body.Block node)
        {
            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    D.WalkDeclaration(block, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    block.Add(S.WalkStatement(block, stmt));
                }
                else
                {
                    Assert(false);
                }
            }
        }

        private void FuncyBody(CodeBlock block, A.Body.Deferred node)
        {
            Assert(block.Funcy.IsAbstract || block.Funcy.IsNative);

            block.Add(new Stmt.Unreachable(node.GetLocation(), block));
        }

        private void FuncyBody(CodeBlock block, A.Body.Expr node)
        {
            var delayed = E.ResolveExpression(block, node.Expression);

            block.Add(new Stmt.Return(node.Expression.GetLocation(), block, delayed));
        }
    }
}
