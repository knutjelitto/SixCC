using SixCC.Writing;

namespace SixCC.Sdk.Automata
{
    public abstract partial class FA<TFA>
        where TFA : FA<TFA>
    {
        protected FA(Factory factory, State start)
        {
            Factory = factory;
            Start = start;
            States = Enumerate(start).Select((state, i) => { state.ID = i; return state; }).ToList();
        }

        public Factory Factory { get; }
        public State Start { get; }
        public List<State> States { get; }
        public IEnumerable<State> Finals => States.Where(state => state.IsFinal);
        public bool IsTerminal => Factory.IsTerminal;
        public bool IsNonterminal => !Factory.IsTerminal;

        protected abstract bool IsFinal(State state);

        public void Dump(Writer writer, int current)
        {
            foreach (var state in States)
            {
                var aa = current == state.ID ? "[" : ".";
                var ab = state.IsFinal ? "(" : ".";
                var oa = state.IsFinal ? ")" : ".";
                var ob = current == state.ID ? "]" : ".";

                writer.WriteLine($"{aa}{ab}{state.ID}{oa}{ob}");
                using (writer.Indent())
                {
                    foreach (var transition in state.TerminalTransitions)
                    {
                        writer.WriteLine($"{transition.Stringize()}");
                    }
                }
            }
        }

        public void Dump(Writer writer)
        {
            foreach (var state in States)
            {
                var finA = IsFinal(state) ? "|" : ".";
                var finB = IsFinal(state) ? "|" : ".";

                writer.WriteLine($"{finA}{state.ID}{finB}");
                using (writer.Indent())
                {
                    foreach (var transition in state.Transitions)
                    {
                        writer.WriteLine($"{transition.Stringize()}");
                    }
                }
            }
        }

        protected TFA CloneIf(bool cloned)
        {
            return cloned ? Clone() : (TFA)this;
        }

        protected Dictionary<State, State> CloneMap()
        {
            var map = new Dictionary<State, State>();

            State Map(State state)
            {
                Debug.Assert(state != null);

                if (!map.TryGetValue(state, out var mapped))
                {
                    mapped = new State(Factory, state.IsFinal);
                    mapped.AddPayload(state);
                    map.Add(state, mapped);

                    foreach (var transition in state.Transitions)
                    {
                        mapped.AddTransition(transition.Clone(Map(transition.Target)));
                    }
                }

                return mapped;
            }

            foreach (var state in States)
            {
                Map(state);
            }

            return map;
        }

        public abstract TFA Clone();

        private static IEnumerable<State> Enumerate(State start)
        {
            var visited = new HashSet<State>();

            void Visit(State state)
            {
                if (!visited.Contains(state))
                {
                    state.ID = visited.Count;
                    visited.Add(state);

                    foreach (var transition in state.Transitions)
                    {
                        Visit(transition.Target);
                    }
                }
            }

            Visit(start);

            return visited.OrderBy(state => state.ID);
        }
    }
}
