namespace Six.Ceylon.Ast
{
    public sealed record Variable(Typo? Type, Identifier Name, ParameterListList Parameters) : Pattern
    {
    }
}
