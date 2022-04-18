using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Stmt : StmtOrDecl
    {
        public sealed record If(IRNode Tree, Expression.Conditions Conditions, Body Then, Body? Else) : Stmt, Body;
        public sealed record For(IRNode Tree, Pattern Pattern, Expression Expression, Body.Block Block, Body.Block? Else) : Stmt;
        public sealed record While(IRNode Tree, Expression.Conditions Conditions, Body.Block Block) : Stmt;
        public sealed record Return(IRNode Tree, Expression? Expression) : Stmt;
        public sealed record Throw(IRNode Tree, Expression? Expression) : Stmt;
        public sealed record Assert(IRNode Tree, Expression.Literal.String? Message, Expression.Conditions Conditions) : Stmt;
        public sealed record Expr(IRNode Tree, Expression Expression) : Stmt;
        public sealed record Assign(IRNode Tree, Expression Left, Expression Right) : Stmt;

        public sealed record Guarded(IRNode Tree, Expression.Conditions Conditions, Body.Block Block) : Stmt;
        public sealed record Guardeds(IRNode Tree, IEnumerable<Guarded> Items) : Many<Guarded>(Tree, Items);
    }
}
