namespace Six.Ceylon.Ast
{
    public record TypeConstraint(
        Identifier? Name, 
        TypeParameterList? TypeParameters, 
        CaseTypes? CaseTypes, 
        Satisfied? Satisfied) : Typo;
}
