namespace Six.Ceylon.Ast
{
    public record TypeList(IEnumerable<Typo> Items) : ReadOnlyList<Typo>(Items.ToList()), Typo;
}
