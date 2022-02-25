using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        A.Stmt AStmt { get; }

        public sealed record Return(Scope Container, A.Stmt AStmt) : Stmt
        {
            public Expr? Expr { get; set; } = null;
        }
    }

    public record Statement(Scope Container, A.Stmt AStmt) : Stmt
    {
    }
}
