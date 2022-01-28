namespace Six.Ceylon.Ast
{
    public sealed record DeclarationList(IEnumerable<Declaration> Items) : ReadOnlyList<Declaration>(Items);
}
