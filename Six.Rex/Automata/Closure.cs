namespace Six.Rex
{
    public class Closure
    {
        public Closure(State state, State end)
            : this(Enumerable.Repeat(state, 1), end)
        {
        }

        public Closure(IEnumerable<State> states, State end)
        {
            var set = new HashSet<State>();
            var isFinal = false;

            foreach (var state in states)
            {
                foreach (var closureState in state.Closure())
                {
                    if (closureState.Equals(end))
                    {
                        isFinal = true;
                    }

                    set.Add(closureState);
                }
            }

            Set = set;
            DfaState = new State(isFinal);
            hashCode = Set.Hash();
        }

        public Dictionary<Integers, HashSet<State>> UnambiguateTransitions()
        {
            var transitions = new Dictionary<Integers, HashSet<State>>();

            void Handle(Integers terminal, State target)
            {
                HandleMore(terminal, Enumerable.Repeat(target, 1));
            }

            void HandleMore(Integers added, IEnumerable<State> targets)
            {
                var already = transitions.Keys.FirstOrDefault(t => t.Overlaps(added));

                if (already == null)
                {
                    transitions.Add(added, new HashSet<State>(targets));
                    return;
                }

                if (already.Equals(added))
                {
                    transitions[already].AddRange(targets);
                    return;
                }

                var alreadyTransitions = transitions[already];

                var newAlready = already / added;
                var newAdded = added / already;
                var intersection = (already + added) / (newAlready + newAdded);

                if (!newAlready.IsEmpty)
                {
                    transitions.Remove(already);
                    HandleMore(newAlready, alreadyTransitions);
                }
                if (!intersection.IsEmpty)
                {
                    HandleMore(intersection, alreadyTransitions.Concat(targets));
                }
                if (!newAdded.IsEmpty)
                {
                    HandleMore(newAdded, targets);
                }
            }

            foreach (var state in Set)
            {
                foreach (var transition in state.TerminalTransitions)
                {
                    Handle(transition.Set, transition.Target);
                }
            }

            EnsureDistinct(transitions);

            return transitions;
        }

        public HashSet<State> Set { get; }

        public State DfaState { get; }

        public override bool Equals(object? obj)
        {
            return obj is Closure other && Set.SetEquals(other.Set);
        }

        public override int GetHashCode() => hashCode;

        [Conditional("DEBUG")]
        private static void EnsureDistinct(Dictionary<Integers, HashSet<State>> transitions)
        {
            var terminals = transitions.Keys.ToList();
            var i = 0;
            while (i < terminals.Count)
            {
                var j = i + 1;
                while (j < terminals.Count)
                {
                    if (terminals[i].Overlaps(terminals[j]))
                    {
                        throw new Exception($"terminal set {terminals[i]} and {terminals[j]} overlap");
                    }
                    j += 1;
                }
                i += 1;
            }
        }

        private readonly int hashCode;
    }
}
