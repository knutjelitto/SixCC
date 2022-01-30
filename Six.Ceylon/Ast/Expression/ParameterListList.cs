namespace Six.Ceylon.Ast
{
    public sealed record ParameterListList(IEnumerable<ParameterList> Items) : ReadOnlyList<ParameterList>(Items.ToList());
}
