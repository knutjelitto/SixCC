using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.CC.Structure
{
    internal class ZeroOrMore : Symbol
    {
        public ZeroOrMore(ILocation location, Symbol symbol)
            : base(location)
        {
            Symbol = symbol;

            IsNullable = true;
        }

        public Symbol Symbol { get; set; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder).ZeroOrMore();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return Symbol.GetNonterminalNfa(builder).ZeroOrMore();
        }

        public override string ToString()
        {
            if (Symbol is Sequence production)
            {
                return $"({production})*";
            }
            return $"{Symbol}*";
        }
    }
}
