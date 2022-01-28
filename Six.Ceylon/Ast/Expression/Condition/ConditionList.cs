namespace Six.Ceylon.Ast
{
    public sealed record ConditionList(IEnumerable<IExpression> Items) : ReadOnlyList<IExpression>(Items);
}
