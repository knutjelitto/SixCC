﻿using SixCC.Sdk.Automata;
using SixCC.Sdk.Earley;
using SixCC.Writing;

namespace SixCC.CC.Dumping
{
    internal static class AutomatonDumper
    {
        public static void Dump(Writer writer, Sdk.Earley.Automaton automaton)
        {
            writer.WriteLine($"earley {automaton.Name}");
            writer.WriteLine();
            using (writer.Indent())
            {
                for (var i = 0; i < automaton.Dfas.Count; i += 1)
                {
                    var dfa = automaton.Dfas[i];
                    var name = dfa.Symbol;
                    DumpRule(i, name, dfa);
                }
            }

            void DumpRule(int index, string name, Sdk.Automata.DFA dfa)
            {
                var attrs = dfa.IsTerminal ? "[terminal]" : "[nonterminal]";

                writer.WriteLine($"[{index}] {name} {attrs}");
                writer.WriteLine();

                using (writer.Indent())
                {
                    dfa.Dump(writer);
                    writer.WriteLine();
                }
            }
        }
    }
}
