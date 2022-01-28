namespace Six.Ceylon.Ast
{
    public sealed record ParameterListList(IEnumerable<ParameterList> items) : ReadOnlyList<ParameterList>(items);
}
