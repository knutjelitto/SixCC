namespace Six.Ceylon.Ast
{
    public sealed class SpreadArgument : Node, Argument
    {
        public SpreadArgument(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }
}
