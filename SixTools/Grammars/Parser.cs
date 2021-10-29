using SixTools.Ast;

namespace SixTools.Grammars
{
    internal abstract class Parser
    {
        public abstract Grammar Parse(string subject);

        public abstract string Extension { get; }
    }
}
