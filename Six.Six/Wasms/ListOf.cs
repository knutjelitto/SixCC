using System.Collections;

namespace Six.Six.Wasms
{
    public class ListOf<T> : IReadOnlyList<T>
    {
        private readonly List<T> items = new();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }
}
