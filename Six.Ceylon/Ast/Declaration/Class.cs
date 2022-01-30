namespace Six.Ceylon.Ast
{
    public record Class(Annotations Annotations, Identifier Name) : Decl.Core(Annotations, Name);
}
