using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Any : Symbol
    {
        public Any(ILocation location)
            : base(location)
        {
            IsNullable = false;
            IsTerminal = true;
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            return builder.Any();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return builder.Any();
        }

        public override string ToString() => ".";
    }
}
