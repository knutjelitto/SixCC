using SixCC.Writing;

namespace SixCC.Sdk.Earley
{
    public class AutomatonDot
    {
        public AutomatonDot(Writer writer, Automaton automaton)
        {
            Writer = writer;
            Automaton = automaton;
        }

        public Writer Writer { get; }
        public Automaton Automaton { get; }

        public void Dot()
        {
            Writer.WriteLine($"digraph");
            Writer.WriteLine("{");
            using (Writer.Indent())
            {
                Writer.WriteLine("rankdir = LR;");
                foreach (var dfa in Automaton.Dfas.OrderByDescending(d => d.ID))
                {
                    Writer.WriteLine($"n_{dfa.ID}");
                    Writer.WriteLine($"  [label=\"{dfa.Symbol}\"]");
                    Writer.WriteLine($"  [shape=box]");
                    Writer.WriteLine($"n_{dfa.ID} -> n_{dfa.ID}_0");
                    Writer.WriteLine($"  [style=invis]");

                    foreach (var state in dfa.States)
                    {
                        Writer.WriteLine($"n_{dfa.ID}_{state.ID}");
                        Writer.WriteLine($"  [label={state.ID}]");
                        if (state.IsFinal)
                        {
                            Writer.WriteLine($"  [shape=doublecircle]");
                        }
                        else
                        {
                            Writer.WriteLine($"  [shape=circle]");
                        }
                    }
                }
                foreach (var dfa in Automaton.Dfas)
                {
                    foreach (var state in dfa.States)
                    {
                        foreach (var transition in state.Transitions)
                        {
                            Writer.WriteLine($"n_{dfa.ID}_{state.ID} -> n_{dfa.ID}_{transition.Target.ID}");
                            if (dfa.IsTerminal)
                            {
                                Writer.WriteLine($"  [label=\"{transition.Set}\"]");
                            }
                            else
                            {
                                Writer.WriteLine($"  [label=\"{Automaton.Dfas[transition.Set.Single].Symbol}\"]");
                            }
                        }
                    }
                }
            }
            Writer.WriteLine("}");
        }
    }
}
