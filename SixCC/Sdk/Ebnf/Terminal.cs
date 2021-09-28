using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public sealed class Terminal : Rule
    {
        public Terminal(ILocation location, string name, Symbol symbol)
            : base(location, name, symbol)
        {
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder);
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return builder.Range(Number, Number);
        }
    }
}
