using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Stmt : Member
    {
        A.Stmt AStmt { get; }
    }

    public record Statement(Scope Container, A.Stmt AStmt) : Stmt;
}
