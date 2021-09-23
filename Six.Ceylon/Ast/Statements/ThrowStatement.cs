namespace Six.Ceylon.Ast
{
    public sealed class ThrowStatement : Node, Statement
    {
        public ThrowStatement(Expression? expression)
        {
            Expression = expression;
        }

        public Expression? Expression { get; }
    }
}
