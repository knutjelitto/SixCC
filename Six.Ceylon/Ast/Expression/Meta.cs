namespace Six.Ceylon.Ast
{
    public interface Meta : IExpression
    {
        public sealed record Class(ReferencePath Path) : Meta;
        public sealed record Value(ReferencePath Path) : Meta;
        public sealed record Function(ReferencePath Path) : Meta;
    }
}
