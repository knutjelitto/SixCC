namespace Six.Ceylon.Ast
{
    public sealed record CatchBlock(Variable? Variable, Block Block) : Expr;
}
