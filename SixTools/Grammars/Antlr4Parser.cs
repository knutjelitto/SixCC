using SixTools.Ast;

namespace SixTools.Grammars
{
    internal partial class Antlr4Parser : Parser
    {
        public override Grammar Parse(string subject)
        {
            return Parse(subject, null);
        }

        public override string Extension => ".g4";
    }
}
