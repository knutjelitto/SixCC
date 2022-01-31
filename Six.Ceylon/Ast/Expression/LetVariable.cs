namespace Six.Ceylon.Ast
{
    public sealed record LetVariableList(IEnumerable<Pattern.LetVariable> Items) : ReadOnlyList<Pattern.LetVariable>(Items);
}
