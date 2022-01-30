namespace Six.Ceylon.Ast
{
    public record Object(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
