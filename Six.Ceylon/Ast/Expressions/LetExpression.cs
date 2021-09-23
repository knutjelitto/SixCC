namespace Six.Ceylon.Ast
{
    public sealed class LetExpression : Node, Expression
    {
        public LetExpression(PatternsWithValue patterns, Expression? expression)
        {
            Patterns = patterns;
            Expression = expression;
        }

        public PatternsWithValue Patterns { get; }
        public Expression? Expression { get; }
    }
}
