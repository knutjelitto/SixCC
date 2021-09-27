using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    public class StatePair : IEnumerable<State>
    {
        private readonly HashSet<State> set;

        public StatePair()
            : this(new HashSet<State>())
        {
        }

        private StatePair(HashSet<State> states)
        {
            set = states;
        }

        public int Count => set.Count;

        public bool IsEmpty => set.Count == 0;

        public static bool operator ==(StatePair s1, StatePair s2)
        {
            if (s1 is null || s2 is null)
            {
                return false;
            }

            return s1.Equals(s2);
        }

        public static bool operator !=(StatePair s1, StatePair s2)
        {
            return !(s1 == s2);
        }

        public void Add(State state)
        {
            set.Add(state);
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

        public StatePair ExceptWith(StatePair other)
        {
            var except = new HashSet<State>(set);
            except.ExceptWith(other.set);

            return new StatePair(except);
        }

        public IEnumerator<State> GetEnumerator()
        {
            return set.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return set.Hash();
        }

        public StatePair IntersectWith(StatePair other)
        {
            var intersect = new HashSet<State>(set);
            intersect.IntersectWith(other.set);

            return new StatePair(intersect);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}