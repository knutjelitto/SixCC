using Six.Runtime.Types;

namespace Six.Ceylon
{
    public partial class CeylonTree
    {
        private static string Text(RLiteral str)
        {
            var text = str.GetEscapedText();
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                return text[1..^1];
            }
            return text;
        }
    }
}
