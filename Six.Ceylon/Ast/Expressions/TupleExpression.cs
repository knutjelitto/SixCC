namespace Six.Ceylon.Ast
{
    public sealed class TupleExpression : Node, Expression
    {
        public TupleExpression(ArgumentList arguments)
        {
            Arguments = arguments;
        }

        public ArgumentList Arguments { get; }
    }
}
