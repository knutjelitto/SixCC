using SixCC.Runtime.Concretes;
using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal abstract class Family : Node, IReadOnlyList<Node>
    {
        private readonly List<Node> children = new();

        public Family(ILocation location, IEnumerable<Node> children)
        {
            this.children.AddRange(children);
            Location = location;
        }

        public Family(Node first, IEnumerable<Node> children)
        {
            this.children.Add(first);
            this.children.AddRange(children);
            Location = this.children.First().Location;
        }

        public Family(Node first, params Node[] children)
        {
            this.children.Add(first);
            this.children.AddRange(children);
            Location = this.children.First().Location;
        }

        public ILocation Location { get; }

        public abstract string Head { get; }

        public Node this[int index] => children[index];
        public int Count => children.Count;
        public IReadOnlyList<Node> Children => children;
        public IEnumerator<Node> GetEnumerator() => children.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
