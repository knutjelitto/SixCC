using SixCC.Sdk.Automata;
using SixCC.Sdk.Earley;
using SixCC.Sdk.Ebnf;

namespace SixCC.CC.Analyzers
{
    internal class AutomatonBuilder
    {
        public Sdk.Earley.Automaton Build(Grammar grammar)
        {
            var dfas = new List<Sdk.Automata.DFA>();
            int i = 0;

            var terminal = new UnicodeFactory();
            var syms = grammar.Symbols;
            var nonterminal = new SymbolFactory(syms);

            while (i < grammar.Rules.Count && grammar.Rules[i].IsNonterminal)
            {
                AddNonterminal(grammar.Rules[i]);
            }

            while (i < grammar.Rules.Count && grammar.Rules[i].IsTerminal && !grammar.Rules[i].IsFragment)
            {
                AddTerminal(grammar.Rules[i]);
            }

            return new Sdk.Earley.Automaton(grammar.Name, dfas);

            void Add(Sdk.Automata.DFA dfa, Rule rule)
            {
                dfa.ID = i;
                dfa.Symbol = rule.Name;
                dfas.Add(dfa);
                i += 1;
            }

            void AddNonterminal(Rule rule)
            {
                var dfa = rule.Symbol.GetNonterminalNfa(nonterminal).ToFinalDfa().Explode();
                Add(dfa, rule);
            }

            void AddTerminal(Rule rule)
            {
                var dfa = rule.Symbol.GetTerminalNfa(terminal).ToFinalDfa();
                Add(dfa, rule);
            }
        }
    }
}
