namespace Six.Ast
{
    public class NotPredicate : Expression, IWithOne
    {
        internal NotPredicate(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
