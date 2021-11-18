using Six.Core;

namespace Six.Ast
{
    public class Literal : Terminal
    {
        internal Literal(ILocation? location, CpString text)
            : base(location)
        {
            Text = text;
        }

        internal Literal(ILocation? location, string text)
            : this(location, new CpString(text))
        {
        }

        internal Literal(ILocation? location, int codepoint)
            : this(location, new CpString(codepoint))
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
