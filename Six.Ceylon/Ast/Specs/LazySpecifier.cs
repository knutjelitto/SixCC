namespace Six.Ceylon.Ast
{
    public sealed class LazySpecifier : Node, Specifier, Definition
    {
        public LazySpecifier(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }
}
