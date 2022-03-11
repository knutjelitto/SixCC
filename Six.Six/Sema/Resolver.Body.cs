using Six.Core.Errors;
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
        private Body WalkBody(Scope scope, A.Body node)
        {
            return Body((dynamic)scope, (dynamic)node);
        }

        private Body Body(BlockScope container, A.Body node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Body Body(BlockScope container, A.Body.Block node)
        {
            foreach (var member in node.Statelarations)
            {
                if (member is A.Decl decl)
                {
                    WalkDeclaration(container, decl);
                }
                else if (member is A.Stmt stmt)
                {
                    WalkStatement(container, stmt);
                }
                else
                {
                    Assert(false);
                }
            }

            return new Body.Dummy();
        }

        private Body Body(BlockScope container, A.Body.Deferred node)
        {
            return new Body.Dummy();
        }

        private Body Body(BlockScope container, A.Body.Value node)
        {
            var delayed = ResolveExpression(container, node.Expression);

            return new Body.Value(() =>
            {
                if (delayed.Resolved != null)
                {
                    return delayed.Resolved;
                }

                throw new DiagnosticException(
                    new SemanticError(node.GetLocation(), $"can't resolve expression ``{node}´´"));
            });
        }

        private Body Body(BlockScope container, A.Body.Calc node)
        {
            return new Body.Dummy();
        }
    }
}
