using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Grammars
{
    public class TerminalList : UniqueList<Symbol, Terminal>
    {
        public TerminalList()
            : base(terminal => terminal, new Symbol.NamesEquals())
        {
        }
    }
}
