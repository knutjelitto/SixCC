namespace SixBot.Ast
{
    internal class Seq : Expression
    {
        public Seq(params Expression[] expressions)
        {
            Expressions = expressions.ToList();
        }

        public List<Expression> Expressions { get; }
    }
}
