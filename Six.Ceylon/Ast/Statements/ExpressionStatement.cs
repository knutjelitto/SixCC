namespace Six.Ceylon.Ast
{
    public sealed class ExpressionStatement : Node, Statement
    {
        public ExpressionStatement(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }
}
