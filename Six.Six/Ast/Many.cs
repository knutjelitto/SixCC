using Six.Runtime.Types;
using System.Collections;

namespace Six.Six.Ast
{
    public record Many<T> : TreeNodeImpl, NodeList, IReadOnlyList<T>
        where T : TreeNode
    {
        private readonly List<T> items;

        public Many(IRNode tree, IEnumerable<T> items)
            : base(tree)
        {
            this.items = items.ToList();
            Tree = tree;
        }

        IEnumerable<TreeNode> NodeList.Items => (IEnumerable<TreeNode>)items;

        public T this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)items).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }
}
