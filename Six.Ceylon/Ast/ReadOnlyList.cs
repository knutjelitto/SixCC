namespace Six.Ceylon.Ast
{
    public record ReadOnlyList<T> : IReadOnlyList<T>, AstList
        where T : AstNode
    {
        private readonly List<T> items;

        protected ReadOnlyList(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public T this[int index] => items[index];
        public int Count => items.Count;

        IEnumerable<AstNode> AstList.Items => (IEnumerable<AstNode>)items;
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }
}
