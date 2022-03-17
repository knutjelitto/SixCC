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
        public Body WalkBody(Decl.Classy classy, A.Body node)
        {
            return ClassyBody(classy, (dynamic)node);
        }

        private Body ClassyBody(Decl.Classy classy, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Body ClassyBody(Decl.Classy classy, A.Body.Class node)
        {
            foreach (var decl in node.Declarations)
            {
                WalkDeclaration(classy.Block.Scope, decl);
            }

            return new Body.Dummy();
        }

        public Body WalkBody(Decl.Funcy funcy, A.Body node)
        {
            return FuncyBody(funcy, (dynamic)node);
        }

        private Body FuncyBody(Decl.Funcy funcy, A.Body.Block node)
        {
            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    WalkDeclaration(funcy.Block.Scope, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    WalkStatement(funcy, stmt);
                }
                else
                {
                    Assert(false);
                }
            }

            return new Body.Dummy();
        }

        private Body FuncyBody(Decl.Funcy funcy, A.Body.Deferred node)
        {
            return new Body.Dummy();
        }

        private Body FuncyBody(Decl.Funcy funcy, A.Body.Calc node)
        {
            var delayed = ResolveExpression(funcy.Block.Scope, node.Expression);

            return new Body.Expression(() => delayed.Expr);
        }
    }
}
