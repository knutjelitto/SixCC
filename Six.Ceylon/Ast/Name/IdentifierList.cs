namespace Six.Ceylon.Ast
{
    public sealed record IdentifierList(IEnumerable<Identifier> Items) : ReadOnlyList<Identifier>(Items);
}
