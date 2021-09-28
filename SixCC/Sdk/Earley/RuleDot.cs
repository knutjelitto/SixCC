using SixCC.Sdk.Ebnf;
using SixCC.Writing;

namespace SixCC.Sdk.Earley
{
    public class RuleDot
    {
        public RuleDot(Writer writer, Rule rule)
        {
            Writer = writer;
            Rule = rule;
        }

        public Writer Writer { get; }
        public Rule Rule { get; }

        public void Dot()
        {
            Writer.WriteLine($"digraph {Rule.Name}");
            Writer.WriteLine("{");
            using (Writer.Indent())
            {
                Writer.WriteLine("rankdir = LR;");
                Writer.WriteLine($"label = \"{Rule.Name}\"");
                Writer.WriteLine($"labeljust = left");

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
            Writer.WriteLine("}");
        }

        private (string left, string right) DoDot(Symbol symbol)
        {
            return Dot((dynamic)symbol);
        }

        private (string left, string right) Dot(Symbol symbol)
        {
            return (string.Empty, string.Empty);
        }
    }
}
