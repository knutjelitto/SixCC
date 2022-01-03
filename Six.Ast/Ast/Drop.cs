namespace Six.Ast
{
    public class Drop : Expression, IWithOne
    {
        internal Drop(ILocation location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; set; }

        public override bool IsSimple => Expression.IsSimple;
    }
}
