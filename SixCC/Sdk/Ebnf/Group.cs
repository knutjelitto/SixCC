using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public sealed class Group : Bracketed
    {
        public Group(ILocation location, Symbol symbol)
            : base(location, symbol)
        {
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }

        public override NFA GetTerminalNfa(Factory builder)
        {
            throw new NotImplementedException();
        }
    }
}
