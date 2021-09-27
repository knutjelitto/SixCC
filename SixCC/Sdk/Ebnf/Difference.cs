using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public class Difference : Symbol
    {
        public Difference(ILocation location, Symbol left, Symbol right)
            : base(location)
        {
            Left = left;
            Right = right;

            IsNullable = false;
            IsTerminal = true;
        }

        public Symbol Left { get; set; }
        public Symbol Right { get; set; }

        public override NFA GetTerminalNfa(Factory builder)
        {
            var left = Left.GetTerminalNfa(builder).ToDfa();
            var right = Right.GetTerminalNfa(builder).ToDfa();
            return Operations.Difference(left, right).ToNfa();
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            var left = Left.GetNonterminalNfa(builder).ToDfa();
            var right = Right.GetNonterminalNfa(builder).ToDfa();
            return Operations.Difference(left, right).ToNfa();
        }

        public override string ToString() => $"{Left} - {Right}";
    }
}
