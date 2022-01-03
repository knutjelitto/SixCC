namespace Six.Ast
{
    public class Lift : Expression, IWithOne
    {
        internal Lift(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
