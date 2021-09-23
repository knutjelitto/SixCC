using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.CC.Structure
{
    internal sealed class Rule : Symbol
    {
        public Rule(ILocation location, string name, Symbol symbol)
            : base(location)
        {
            Name = name;
            Symbol = symbol;
        }

        public string Name { get; }
        public Symbol Symbol { get; }
        public ISet<Rule> Usages { get; } = new HashSet<Rule>();

        public override NFA GetTerminalNfa(Factory builder)
        {
            return Symbol.GetTerminalNfa(builder);
        }

        public override NFA GetNonterminalNfa(Factory builder)
        {
            return builder.Range(Number, Number);
        }

        public override string ToString() => Name;
    }
}
