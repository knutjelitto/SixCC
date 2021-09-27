using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class OneOrMore : Bracketed
    {
        public OneOrMore(ILocation location, Symbol symbol)
            : base(location)
        {
            Symbol = symbol;
        }

        public Symbol Symbol { get; set; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder).OneOrMore();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return Symbol.GetNonterminalNfa(builder).OneOrMore();
        }

        public override string ToString()
        {
            if (Symbol is Sequence production)
            {
                return $"({production})+";
            }
            return $"{Symbol}+";
        }
    }
}
