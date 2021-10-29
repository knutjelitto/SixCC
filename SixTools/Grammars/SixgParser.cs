using SixTools.Ast;

namespace SixTools.Grammars
{
    internal partial class SixgParser : Parser
    {
        public override Grammar Parse(string subject)
        {
            return Parse(subject, null);
        }

        public override string Extension => ".sixg";
    }
}
