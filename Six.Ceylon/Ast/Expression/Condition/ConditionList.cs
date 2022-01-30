namespace Six.Ceylon.Ast
{
    public sealed record ConditionList(IEnumerable<Expr> Items) : ReadOnlyList<Expr>(Items.ToList());
}
