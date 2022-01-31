namespace Six.Ceylon.Ast
{
    public sealed record CatchBlock(Pattern.Variable? Variable, Block Block) : Expr;
}
