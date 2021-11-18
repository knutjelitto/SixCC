namespace Six.Ast
{
    public class Compact : Terminal
    {
        internal Compact(ILocation? location, Expression expression)
            : base(location)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override string ToName() => $"<{Expression.ToName()}>";
    }
}
