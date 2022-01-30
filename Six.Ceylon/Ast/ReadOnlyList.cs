namespace Six.Ceylon.Ast
{
    public record ReadOnlyList<T> : IReadOnlyList<T>
    {
        private readonly List<T> items;

        protected ReadOnlyList(List<T> items)
        {
            this.items = items;
        }

        public T this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }
}
