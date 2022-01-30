namespace Six.Ceylon.Ast
{
    public sealed record TypePath(IEnumerable<TypeReference> Items)
        : ReadOnlyList<TypeReference>(Items.ToList()), Typo, QualifiedClass;
}
