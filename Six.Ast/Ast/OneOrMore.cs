namespace Six.Ast
{
    public class OneOrMore : Expression, IWithOne
    {
        internal OneOrMore(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
