using Six.Core;

namespace SixBot.Ast
{
    internal class Literal : Expression
    {
        public Literal(CpString text)
        {
            Text = text;
        }

        public CpString Text { get; }

        public override string ToString()
        {
            return $"'{Text}'";
        }
    }
}
