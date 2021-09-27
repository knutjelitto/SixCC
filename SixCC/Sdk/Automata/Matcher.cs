namespace SixCC.Sdk.Automata
{
    public class Matcher
    {
        public Matcher(DFA automaton)
        {
            FA = automaton;
            State = FA.Start;
        }

        public DFA FA { get; }

        public State State { get; private set; }

        public bool FullMatch(string characters)
        {
            State = FA.Start;

            foreach (var character in characters)
            {
                var matched = false;

                foreach (var transition in State.Transitions)
                {
                    if (transition.Set.Contains(character))
                    {
                        State = transition.Target;
                        matched = true;
                        break;
                    }
                }

                if (!matched)
                {
                    return false;
                }
            }

            return State.IsFinal;
        }
    }
}