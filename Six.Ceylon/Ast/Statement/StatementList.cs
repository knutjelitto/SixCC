namespace Six.Ceylon.Ast
{
    public sealed record StatementList(IEnumerable<Statement> Items) : ReadOnlyList<Statement>(Items);
}
