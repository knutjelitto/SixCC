using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Ebnf
{
    public abstract class Symbol
    {
        public Symbol(ILocation location)
        {
            Location = location;
        }

        public ILocation Location { get; }

        public bool IsNullable = false;

        public bool IsTerminal = false;
        public bool IsFragment = false;

        public bool IsNonterminal { get; set;  }
        public bool IsCallable => !IsFragment || !IsTerminal;

        public int Number = -1;

        public abstract NFA GetTerminalNfa(Factory builder);
        public abstract NFA GetNonterminalNfa(Factory builder);

        public string Key => this.ToString()!;
    }
}
