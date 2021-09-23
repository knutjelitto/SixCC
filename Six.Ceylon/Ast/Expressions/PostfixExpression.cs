namespace Six.Ceylon.Ast
{
    public sealed class PostfixExpression : Node, Expression
    {
        public PostfixExpression(Terminal op, Expression expression)
        {
            Op = op;
            Expression = expression;
        }

        public Terminal Op { get; }
        public Expression Expression { get; }
    }
}
