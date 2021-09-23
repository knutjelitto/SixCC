namespace Six.Ceylon.Ast
{
    public sealed class IfElseExpression : Node, Expression
    {
        public IfElseExpression(Conditions conditions, ThenExpressionPart thenPart, ElseExpressionPart elsePart)
        {
            Conditions = conditions;
            ThenPart = thenPart;
            ElsePart = elsePart;
        }

        public Conditions Conditions { get; }
        public ThenExpressionPart ThenPart { get; }
        public ElseExpressionPart ElsePart { get; }
    }

    public sealed class ThenExpressionPart : Node
    {
        public ThenExpressionPart(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }

    public sealed class ElseExpressionPart : Node
    {
        public ElseExpressionPart(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }
    }

}
