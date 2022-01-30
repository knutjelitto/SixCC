namespace Six.Ceylon.Ast
{
    public sealed record ParameterList(IEnumerable<Parameter> Items) : ReadOnlyList<Parameter>(Items.ToList());
}
