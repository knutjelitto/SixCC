using Six.Core;

namespace Six.Ast
{
    public class Literal : Terminal
    {
        public Literal(CpString text)
        {
            Text = text;
        }

        public Literal(string text)
            : this(new CpString(text))
        {
        }

        public Literal(int codepoint)
            : this(new CpString(codepoint))
        {
        }

        public CpString Text { get; }

        public override string ToString()
        {
            return $"{Text.Esc()}";
        }


        public override string ToName() => $"{Text.Esc()}";

    }
}
