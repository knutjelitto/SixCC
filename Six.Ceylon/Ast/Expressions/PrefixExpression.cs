namespace Six.Ceylon.Ast
{
    public sealed class PrefixExpression : Node, Expression
    {
        public PrefixExpression(Terminal op, Expression expression)
        {
            Op = op;
            Expression = expression;
        }

        public Terminal Op { get; }
        public Expression Expression { get; }
    }
}
