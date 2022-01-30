namespace Six.Ceylon.Ast
{
    public sealed record TypeParameterList(IEnumerable<TypeParameter> Items) : ReadOnlyList<TypeParameter>(Items.ToList());
}
