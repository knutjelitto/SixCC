using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Statement : TreeNode, Statelaration
    {
        public sealed record If(IRNode Tree, Guardeds Guardeds, Body.Block? Else) : Statement;
        public sealed record For(IRNode Tree, Pattern Pattern, Expression Expression, Body.Block Block, Body.Block? Else) : Statement;
        public sealed record Return(IRNode Tree, Expression? Expression) : Statement;
        public sealed record Throw(IRNode Tree, Expression? Expression) : Statement;
        public sealed record Assert(IRNode Tree, Expression.Literal.String? Message, Expression.Conditions Conditions) : Statement;
        public sealed record Expr(IRNode Tree, Expression Expression) : Statement;
        public sealed record Assign(IRNode Tree, Name Name, Expression Expression) : Statement;

        public sealed record Guarded(IRNode Tree, Expression.Conditions Conditions, Body.Block Block) : Statement;
        public sealed record Guardeds(IRNode Tree, IEnumerable<Guarded> Items) : Many<Guarded>(Tree, Items);
    }
}
