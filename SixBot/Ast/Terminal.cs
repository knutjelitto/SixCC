using Six.Core;

namespace SixBot.Ast
{
    internal class Terminal : Base
    {
        public Terminal(Expression expression)
        {
            Expression = expression;
        }

        public Terminal(CpString literal)
            : this(new Literal(literal))
        {
        }

        public Expression Expression { get; }
    }
}
