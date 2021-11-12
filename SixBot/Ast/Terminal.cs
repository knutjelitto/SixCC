namespace SixBot.Ast
{
    internal class Terminal : Expression
    {
        public Terminal(Expression expression)
        {
            Expression = expression;
        }

        public Terminal(string literal)
            : this(new Literal(literal))
        {
        }

        public Expression Expression { get; }
    }
}
