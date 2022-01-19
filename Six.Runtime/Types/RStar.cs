using System.Collections;

namespace Six.Runtime.Types
{
    public class RStar : RNode
    {
        public RStar(params RNode[] children)
            : base(children)
        {
        }
    }

    public class RStar<T> : RStar, IReadOnlyList<T>
        where T : class
    {
        public RStar(params RNode[] children)
            : base(children)
        {
        }

        public IEnumerable<T> Elements => this;

        public T this[int index] => (T)(object)Children[index];
        public int Count => Children.Length;
        public IEnumerator<T> GetEnumerator() => Children.Cast<object>().Cast<T>().GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
