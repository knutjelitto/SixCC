using SixCC.Runtime.Structures;
using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Earley
{
    public class Parser
    {
        public Parser(ISource source, Automaton automaton)
        {
            Source = source;
            Automaton = automaton;
            Chart = new EarleyChart(this);
        }

        public ISource Source { get; }
        public Automaton Automaton { get; }
        public EarleyChart Chart { get; }

        public IEnumerable<EarleyItem> Recognize()
        {
            return Chart.Earley();
        }

        public bool Match(Automata.DFA dfa, int offset, out int nextOffset, out State state)
        {
            var current = dfa.Start;

            var match = true;
            if(offset >= Source.Length)
            {
                Debug.Assert(true);
            }
            while (match && offset < Source.Length)
            {
                match = false;
                foreach (var transition in current.Transitions)
                {
                    if (transition.Set.Contains(Source[offset]))
                    {
                        offset += 1;
                        current = transition.Target;
                        match = true;
                        break;
                    }
                }
            }

            nextOffset = offset;
            state = current;
            return current.IsFinal;
        }
    }
}
