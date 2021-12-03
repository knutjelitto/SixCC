namespace Six.Ast
{
    public class Token : Expression, IWithOne
    {
        internal Token(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
