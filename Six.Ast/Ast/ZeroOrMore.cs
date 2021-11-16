namespace Six.Ast
{
    public class ZeroOrMore : Expression
    {
        public ZeroOrMore(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})*";
    }
}
