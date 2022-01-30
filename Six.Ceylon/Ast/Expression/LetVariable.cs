namespace Six.Ceylon.Ast
{
    public sealed record LetVariable(Pattern Pattern, Expr.Specifier.Value Specifier) : Pattern, Expr;
    public sealed record LetList(IEnumerable<LetVariable> Items) : ReadOnlyList<LetVariable>(Items.ToList());
}
