using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Epsilon : Symbol
    {
        public Epsilon(ILocation location)
            : base(location)
        {
            IsNullable = true;
            IsTerminal = true;
            IsNonterminal = true;
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return builder.Epsilon();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return builder.Epsilon();
        }

        public override string ToString() => "ε";
    }
}
