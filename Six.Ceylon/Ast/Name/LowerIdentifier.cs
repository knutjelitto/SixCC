using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public sealed class LowerIdentifier : Identifier
    {
        public LowerIdentifier(RToken token, string? text = null)
            : base(token, text ?? GetText(token))
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
