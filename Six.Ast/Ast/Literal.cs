namespace Six.Ast
{
    public class Literal : Expression
    {
        internal Literal(ILocation location, string text)
            : base(location)
        {
            Text = text;
        }

        internal Literal(ILocation location, int codepoint)
            : this(location, char.ConvertFromUtf32(codepoint))
        {
        }

        public string Text { get; }

        public override string ToString()
        {
            return $"{Text.Esc()}";
        }


        public override bool IsSimple => true;
    }
}
