namespace Six.Ceylon.Ast
{
    public sealed record Variadic(Typo? Type, string Op, Identifier Name) : Pattern
    {
    }
}
