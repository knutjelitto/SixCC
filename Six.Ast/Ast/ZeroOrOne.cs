namespace Six.Ast
{
    public class ZeroOrOne : Expression, IWithOne
    {
        internal ZeroOrOne(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
