namespace Six.Ceylon.Ast
{
    public sealed class AnonymousArgument : Node, NamedArgument
    {
        public AnonymousArgument(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }
}
