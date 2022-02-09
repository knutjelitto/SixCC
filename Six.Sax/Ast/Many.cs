using Six.Runtime.Types;
using System.Collections;

namespace Six.Sax.Ast
{
    public record Many<T> : NodeList, IReadOnlyList<T>
        where T : TreeNode
    {
        private readonly List<T> items;

        public Many(IRNode tree, IEnumerable<T> items)
        {
            this.items = items.ToList();
            Tree = tree;
        }

        public IRNode Tree { get; }
        IEnumerable<TreeNode> NodeList.Items => (IEnumerable<TreeNode>)items;

        public T this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)items).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }
}
