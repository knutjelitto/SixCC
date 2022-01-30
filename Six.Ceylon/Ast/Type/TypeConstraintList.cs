namespace Six.Ceylon.Ast
{
    public sealed record TypeConstraintList(IEnumerable<TypeConstraint> Items) : ReadOnlyList<TypeConstraint>(Items.ToList());
}
