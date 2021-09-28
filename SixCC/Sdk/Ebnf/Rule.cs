using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public abstract class Rule : Symbol
    {
        public Rule(ILocation location, string name, Symbol symbol)
            : base(location)
        {
            Name = name;
            Symbol = symbol;
        }

        public string Name { get; }
        public Symbol Symbol { get; set; }
        public ISet<Rule> Usages { get; } = new HashSet<Rule>();
        public override string ToString() => Name;
    }
}
