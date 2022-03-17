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
        private void WalkStatement(Decl.Funcy funcy, A.Stmt node)
        {
            Statement(funcy, (dynamic)node);
        }

        private void Statement(Decl.Funcy funcy, A.Stmt.Assign node)
        {
            var stmt =
                new Stmt.Assign(
                    node,
                    funcy.Block.Scope,
                    ResolveExpression(funcy.Block.Scope, node.Left),
                    ResolveExpression(funcy.Block.Scope, node.Right));
            CurrentFuncy.Members.Add(stmt);
        }

        private void Statement(Decl.Funcy funcy, A.Stmt.Return node)
        {
            var stmt =
                new Stmt.Return(
                    node.GetLocation(),
                    funcy.Block.Scope,
                    (Decl.Function)funcy,
                    node.Expression == null ? null : ResolveExpression(funcy.Block.Scope, node.Expression));
            funcy.Members.Add(stmt);
        }

        private void Statement(Decl.Funcy funcy, A.Stmt.Expr node)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Statement(Decl.Funcy funcy, A.Stmt node)
        {
            Assert(false);
            throw new NotImplementedException();
        }
    }
}
