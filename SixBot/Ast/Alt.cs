namespace SixBot.Ast
{
    internal class Alt : Expression
    {
        public Alt(params Expression[] expressions)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }
    }
}
