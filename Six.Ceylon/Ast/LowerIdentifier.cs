using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public sealed class LowerIdentifier : Identifier
    {
        public LowerIdentifier(RToken token)
            : base(token, GetText(token))
        {
        }

        private static string GetText(RToken token)
        {
            var text = token.Text;

            if (text.StartsWith("\\i"))
                return text[2..];
            return text;
        }
    }
}
