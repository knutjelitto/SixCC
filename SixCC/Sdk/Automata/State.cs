using SixCC.Core;
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    [DebuggerDisplay("{ToString()}")]
    public sealed class State
    {
        public State(Factory factory, bool isFinal = false)
        {
            Factory = factory;
            IsFinal = isFinal;
            ID = -1;
            Payload = -1;
            Transitions = new List<Transition>();
        }

        public Factory Factory { get; }
        public bool IsFinal { get; set; }
        public int ID { get; set; }
        public int Payload { get; private set; }
        public bool IsPayload => Payload >= 0;
        public List<Transition> Transitions { get; }

        public IEnumerable<Transition> EpsilonTransitions => Transitions.Where(t => t.Set.IsEmpty);
        public IEnumerable<Transition> TerminalTransitions => Transitions.Where(t => !t.Set.IsEmpty);

        public void AddPayload(State state)
        {
            if (IsPayload && state.IsPayload)
            {
                throw new ArgumentOutOfRangeException(nameof(state));
            }
            else if (!IsPayload)
            {
                Payload = state.Payload;
            }
        }

        public void SetPayload(int payload)
        {
            if (IsPayload && payload >= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(payload));
            }
            else if (!IsPayload)
            {
                Payload = payload;
            }
        }

        public void AddEpsilonTransition(State target)
        {
            Transitions.Add(new EpsilonTransition(Factory, target));
        }

        public void AddTerminalTransition(IntegerSet terminal, State target)
        {
            Transitions.Add(new TerminalTransition(Factory, terminal, target));
        }

        public void AddTransition(Transition transition)
        {
            Transitions.Add(transition);
        }

        public IEnumerable<State> EpsilonClosure()
        {
            var once = new UniqueQueue<State>();

            once.Enqueue(this);

            while (once.Count > 0)
            {
                var state = once.Dequeue();
                foreach (var transition in state.EpsilonTransitions)
                {
                    once.Enqueue(transition.Target);
                }
            }

            return once.Seen;
        }

        public override string ToString()
        {
            return $"({ID},{IsFinal},{Payload},({string.Join(",", Transitions)}))";
        }
    }
}
