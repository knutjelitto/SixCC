namespace Six.Ceylon.Ast
{
    public record Attribute(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
