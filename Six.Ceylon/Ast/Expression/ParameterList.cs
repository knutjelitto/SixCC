namespace Six.Ceylon.Ast
{
    public sealed record ParameterList(IEnumerable<Parameter> items) : ReadOnlyList<Parameter>(items);
}
