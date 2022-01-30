namespace Six.Ceylon.Ast
{
    public sealed record DeclarationList(IEnumerable<Decl> Items) : ReadOnlyList<Decl>(Items.ToList());
}
