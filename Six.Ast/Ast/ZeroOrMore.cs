namespace Six.Ast
{
    public class ZeroOrMore : Expression, IWithOne
    {
        internal ZeroOrMore(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
