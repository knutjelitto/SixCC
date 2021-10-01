using SixCC.Core;
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    public class StatePair : IEnumerable<State>
    {
        private readonly HashSet<State> set;

        public StatePair(State state1, State state2)
            : this(new HashSet<State>() { state1, state2 })
        {
        }

        private StatePair(HashSet<State> states)
        {
            set = states;
        }

        public void Add(StatePair other)
        {
            set.UnionWith(other);
        }

        public bool Contains(State state)
        {
            return set.Contains(state);
        }

        public bool Overlaps(StatePair other)
        {
            return other.Any(otherState => Contains(otherState));
        }

        public override bool Equals(object? obj)
        {
            return obj is StatePair other && set.SetEquals(other.set);
        }

        public override int GetHashCode()
        {
            return set.Hash();
        }

        IEnumerator<State> IEnumerable<State>.GetEnumerator() => set.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => set.GetEnumerator();
    }
}
