namespace Six.Ceylon.Ast
{
    public sealed class ValueSpecifier : Node, Specifier, Definition
    {
        public ValueSpecifier(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }
}
