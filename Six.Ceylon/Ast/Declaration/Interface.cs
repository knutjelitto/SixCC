namespace Six.Ceylon.Ast
{
    public record Interface(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
