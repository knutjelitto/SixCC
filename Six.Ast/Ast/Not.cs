namespace Six.Ast
{
    public class Not : Expression, IWithOne
    {
        internal Not(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
