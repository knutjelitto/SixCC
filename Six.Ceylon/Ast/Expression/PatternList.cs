namespace Six.Ceylon.Ast
{
    public sealed record PatternList(IEnumerable<Pattern> Items) : ReadOnlyList<Pattern>(Items.ToList());
}
