namespace Six.Ceylon.Ast
{
    public sealed record TypePath(IEnumerable<Expr.TypeReference> Items)
        : ReadOnlyList<Expr.TypeReference>(Items), Type, QualifiedClass;
}
