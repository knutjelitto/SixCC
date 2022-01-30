namespace Six.Ceylon.Ast
{
    public sealed record ArgumentList(IEnumerable<Argument> Items) : ReadOnlyList<Argument>(Items.ToList());
}
