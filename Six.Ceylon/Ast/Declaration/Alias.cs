namespace Six.Ceylon.Ast
{
    public record Alias(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
