#if false
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    public class StateSet : IEnumerable<State>
    {
        public StateSet()
            : this(new HashSet<State>())
        {
        }

        public StateSet(params State[] states)
            : this(states.AsEnumerable())
        {
        }

        public StateSet(IEnumerable<State> states)
            : this(new HashSet<State>(states))
        {
        }

        private StateSet(HashSet<State> states)
        {
            set = states;
        }

        public int Count => set.Count;

        public bool IsEmpty => set.Count == 0;

        public static bool operator ==(StateSet s1, StateSet s2)
        {
            if (s1 is null || s2 is null)
            {
                return false;
            }

            return s1.Equals(s2);
        }

        public static bool operator !=(StateSet s1, StateSet s2)
        {
            return !(s1 == s2);
        }

        public void Add(State state)
        {
            set.Add(state);
        }

        public void Add(StateSet other)
        {
            set.UnionWith(other);
        }

        public bool Contains(State state)
        {
            return this.set.Contains(state);
        }

        public bool Overlaps(StateSet other)
        {
            return other.Any(otherState => Contains(otherState));
        }

        public override bool Equals(object? obj)
        {
            return obj is StateSet other && this.set.SetEquals(other.set);
        }

        public StateSet ExceptWith(StateSet other)
        {
            var except = new HashSet<State>(this.set);
            except.ExceptWith(other.set);

            return new StateSet(except);
        }

        public IEnumerator<State> GetEnumerator()
        {
            return this.set.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return this.set.Hash();
        }

        public StateSet IntersectWith(StateSet other)
        {
            var intersect = new HashSet<State>(this.set);
            intersect.IntersectWith(other.set);

            return new StateSet(intersect);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private readonly HashSet<State> set;
    }
}
#endif