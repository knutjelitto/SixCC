using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.CC.Structure
{
    internal class Complement : Symbol
    {
        public Complement(ILocation location, Symbol symbol)
            : base(location)
        {
            Symbol = symbol;
        }

        public Symbol Symbol { get; set; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return builder.Complement(Symbol.GetTerminalNfa(builder));
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return builder.Complement(Symbol.GetNonterminalNfa(builder));
        }

        public override string ToString()
        {
            return $"!({Symbol})";
        }
    }
}
