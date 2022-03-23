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
        public Body WalkBody(ClassBlock block, A.Body node)
        {
            return ClassyBody(block, (dynamic)node);
        }

        private Body ClassyBody(ClassBlock block, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Body ClassyBody(ClassBlock block, A.Body.Class node)
        {
            foreach (var decl in node.Declarations)
            {
                WalkDeclaration(block, decl);
            }

            return new Body.Dummy();
        }

        public Body WalkBody(FuncBlock block, A.Body node)
        {
            return FuncyBody(block, (dynamic)node);
        }

        private Body FuncyBody(FuncBlock block, A.Body.Block node)
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

            return new Body.Dummy();
        }

        private Body FuncyBody(FuncBlock block, A.Body.Deferred node)
        {
            return new Body.Dummy();
        }

        private Body FuncyBody(FuncBlock block, A.Body.Calc node)
        {
            var delayed = ResolveExpression(block.Content, node.Expression);

            block.Members.Add(new Stmt.Return(node.Expression.GetLocation(), block, delayed));

            return new Body.Dummy();
        }
    }
}
