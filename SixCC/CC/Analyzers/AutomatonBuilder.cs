using SixCC.Sdk.Automata;
using SixCC.Sdk.Earley;
using SixCC.Sdk.Ebnf;

namespace SixCC.CC.Analyzers
{
    internal static class FactoryExtensions
    {
        public static DFA GetDFA(this SymbolFactory nonterminalFactory, Rule rule)
        {
            return rule.Symbol.GetNonterminalNfa(nonterminalFactory).ToFinalDfa().Explode();
        }
        public static DFA GetDFA(this UnicodeFactory terminalFactory, Rule rule)
        {
            return rule.Symbol.GetTerminalNfa(terminalFactory).ToFinalDfa();
        }
    }

    internal class AutomatonBuilder
    {
        public Automaton Build(Grammar grammar)
        {
            var dfas = new List<DFA>();
            int i = 0;

            var terminal = new UnicodeFactory();
            var syms = grammar.Symbols;
            var nonterminal = new SymbolFactory(syms);

            while (i < grammar.Rules.Count && grammar.Rules[i].IsNonterminal)
            {
                Add(nonterminal.GetDFA(grammar.Rules[i]), grammar.Rules[i]);
            }

            while (i < grammar.Rules.Count && grammar.Rules[i].IsTerminal && !grammar.Rules[i].IsFragment)
            {
                Add(terminal.GetDFA(grammar.Rules[i]), grammar.Rules[i]);
            }

            return new Automaton(grammar.Name, dfas);

            void Add(DFA dfa, Rule rule)
            {
                dfa.ID = i;
                dfa.Symbol = rule.Name;
                dfas.Add(dfa);
                i += 1;
            }
        }
    }
}
