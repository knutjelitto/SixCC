using System.Collections.Generic;

namespace SixCC.Sdk.Commons
{
    public class UniqueQueue<T> where T : notnull
    {
        private readonly Dictionary<T, T> set;
        private readonly Queue<T> queue;

        public UniqueQueue()
        {
            set = new Dictionary<T, T>();
            queue = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            if (!set.ContainsKey(item))
            {
                set.Add(item, item);
                queue.Enqueue(item);
            }
        }

        public bool Enqueue(T item, out T already)
        {
            if (set.TryGetValue(item, out var found))
            {
                already = found;
                return false;
            }

            set.Add(item, item);
            queue.Enqueue(item);
            already = item;

            return true;
        }

        public T Dequeue()
        {
            return queue.Dequeue();
        }

        public IEnumerable<T> Seen => set.Keys;

        public int Count => queue.Count;
    }
}
