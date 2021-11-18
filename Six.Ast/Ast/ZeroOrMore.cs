namespace Six.Ast
{
    public class ZeroOrMore : Expression
    {
        internal ZeroOrMore(ILocation? location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})*";
    }
}
