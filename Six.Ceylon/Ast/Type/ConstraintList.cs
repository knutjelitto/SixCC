namespace Six.Ceylon.Ast
{
    public sealed record ConstraintList(IEnumerable<IExpression> Items) : ReadOnlyList<IExpression>(Items);
}
