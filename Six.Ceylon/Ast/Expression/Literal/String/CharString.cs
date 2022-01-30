using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public class CharString : String, Expr
    {
        public CharString(RToken token)
            : base(GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            Assert(token.Text.StartsWith("\'") && token.Text.EndsWith("\'"));

            var text = Decode(token.Text[1..^1]);

            var runes = text.EnumerateRunes().ToList();

            if (runes.Count == 1)
            {
                return text;
            }

            throw new InvalidOperationException("character literal doesn't represent a single codepoint");
        }
    }
}
