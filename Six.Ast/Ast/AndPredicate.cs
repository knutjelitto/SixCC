namespace Six.Ast
{
    public class AndPredicate : Expression, IWithOne
    {
        internal AndPredicate(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
