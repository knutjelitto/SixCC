namespace Six.Ceylon.Ast
{
    public sealed record TypeParameter(string? Variance, Identifier Name, Type? Default) : Type;
}
