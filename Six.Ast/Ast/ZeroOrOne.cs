namespace Six.Ast
{
    public class ZeroOrOne : Expression
    {
        internal ZeroOrOne(ILocation? location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})?";
    }
}
