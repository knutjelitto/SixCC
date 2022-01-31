namespace Six.Ceylon.Ast
{
    public sealed record StatementList(IEnumerable<Stmt> Items) : ReadOnlyList<Stmt>(Items);
}
