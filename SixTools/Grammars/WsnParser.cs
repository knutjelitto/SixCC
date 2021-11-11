using SixTools.Ast;

namespace SixTools.Grammars
{
    internal partial class WsnParser : Parser
    {
        public override Grammar Parse(string subject)
        {
            return Parse(subject, null);
        }

        public override string PreferedExtension => ".wsn";
        public override string FormatName => "wsn";
    }
}
