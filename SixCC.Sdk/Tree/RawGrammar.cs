using System.Collections.Generic;
using System.Diagnostics;
using SixCC.Sdk.Grammars;

namespace SixCC.Sdk.Tree
{
    public class RawGrammar
    {
        public RawGrammar(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public List<Option> Options { get; } = new List<Option>();
        public List<TerminalRule> Terminals { get; } = new List<TerminalRule>();
        public List<NonterminalRule> Nonterminals { get; } = new List<NonterminalRule>();

        public void Add(IEnumerable<Symbol> members)
        {
            switch (members)
            {
                case IEnumerable<Option> options:
                    Options.AddRange(options);
                    break;
                case IEnumerable<NonterminalRule> nonterminals:
                    Nonterminals.AddRange(nonterminals);
                    break;
                case IEnumerable<TerminalRule> terminals:
                    Terminals.AddRange(terminals);
                    break;
            }
        }
    }
}
