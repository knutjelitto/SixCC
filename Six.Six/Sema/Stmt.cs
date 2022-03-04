using Six.Core;
using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        A.Stmt AStmt { get; }

        public sealed record Return(Scope Container, A.Stmt.Return Stmt)
            : Statement(Container, Stmt)
        {
            public Expr.Concrete? Expr { get; set; } = null;
        }

        public sealed record Assign(Scope Container, A.Stmt.Assign Stmt)
            : Statement(Container, Stmt)
        {
            public Expr.Concrete? Left { get; set; } = null;
            public Expr.Concrete? Right { get; set; } = null;
        }
    }

    public record Statement(Scope Container, A.Stmt AStmt) : Stmt
    {
    }
}
