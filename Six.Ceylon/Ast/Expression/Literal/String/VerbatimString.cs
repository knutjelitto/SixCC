using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public sealed class VerbatimString : String
    {
        public VerbatimString(RToken token)
            : base(GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            var text = token.Text;

            Assert(text.StartsWith("\"\"\"") && text.EndsWith("\"\"\""));

            return text[3..^3];
        }
    }
}
