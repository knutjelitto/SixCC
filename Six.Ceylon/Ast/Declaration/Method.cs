namespace Six.Ceylon.Ast
{
    public record Method(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
