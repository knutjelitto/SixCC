namespace SixBot.Ast
{
    internal class Alt : Expression
    {
        public Alt(params Expression[] expressions)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }

        public override bool IsAtomic => Expressions.Count == 1 && Expressions[0].IsAtomic;

        public override string ToName() => $"({string.Join("|", Expressions.Select(e => e.ToName()))})";
    }
}
