namespace Six.Ceylon.Ast
{
    public sealed class IterableExpression : Node, Expression
    {
        public IterableExpression(ArgumentList arguments)
        {
            Arguments = arguments;
        }

        public ArgumentList Arguments { get; }
    }
}
