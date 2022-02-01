namespace Six.Ceylon.Ast
{
    public sealed record TypeConstraint(
        Identifier? Name, 
        TypeParameters? TypeParameters, 
        CaseTypes? CaseTypes, 
        Satisfies? Satisfied) : Type;

    public sealed record TypeConstraints(IEnumerable<TypeConstraint> Items)
        : ReadOnlyList<TypeConstraint>(Items);
}
