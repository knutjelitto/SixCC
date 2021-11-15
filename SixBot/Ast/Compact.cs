namespace SixBot.Ast
{
    internal class Compact : Terminal
    {
        public Compact(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override string ToName() => $"<{Expression.ToName()}>";
    }
}
