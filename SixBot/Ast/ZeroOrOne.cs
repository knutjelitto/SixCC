namespace SixBot.Ast
{
    internal class ZeroOrOne : Expression
    {
        public ZeroOrOne(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression { get; }

        public override bool IsAtomic => Expression.IsAtomic;

        public override string ToName() => $"({Expression.ToName()})?";
    }
}
