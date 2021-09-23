namespace Six.Ceylon.Ast
{
    public sealed class IndexExpression : Node, Expression
    {
        public IndexExpression(Expression expression, IndexRange index)
        {
            Expression = expression;
            Index = index;
        }

        public Expression Expression { get; }
        public IndexRange Index { get; }
    }

    public sealed class IndexRange : Node
    {
        public IndexRange(IndexRangeKind kind, Expression? one, Expression? two)
        {
            Kind = kind;
            One = one;
            Two = two;
        }

        public IndexRangeKind Kind { get; }
        public Expression? One { get; }
        public Expression? Two { get; }
    }

    public enum IndexRangeKind
    {
        UpTo,
        FromUp,
        FromTo,
        FromLength,
        Index,
    }
}
