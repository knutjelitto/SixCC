namespace Six.Ast
{
    public class Compact : Expression, IWithOne
    {
        internal Compact(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
