namespace Six.Ast
{
    public class OneOrMore : Expression
    {
        public OneOrMore(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})+";
    }
}
