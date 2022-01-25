using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public sealed class UpperIdentifier : Identifier
    {
        public UpperIdentifier(RToken token)
            : base(token, GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            var text = token.Text;

            if (text.StartsWith("\\I"))
                return text[2..];
            return text;
        }
    }
}
