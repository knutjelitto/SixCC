using Six.Core;

namespace Six.Runtime.Tree
{
    internal class TreeDumper : IWithWriter
    {
        private Dictionary<string, Node> cache;
        public TreeDumper(Node root, Writer writer)
        {
            Root = root;
            Writer = writer;
            cache = new();
        }

        public Node Root { get; }
        public Writer Writer { get; }

        protected IWithWriter w => this;

        public void Dump()
        {
            w.wl("hello");
            Dump(Root);
        }

        private void Dump(Node anyNode)
        {
            var key = anyNode.ToString();
            if (cache.TryGetValue(key, out var already))
            {
                w.wl($"=> {already}");
            }
            else
            {
                cache.Add(key, anyNode);
                switch (anyNode)
                {
                    case Nonterminal node:
                        Dump(node);
                        break;
                    case Terminal node:
                        Dump(node);
                        break;
                    case Packed node:
                        Dump(node);
                        break;
                    case Intermediate node:
                        Dump(node);
                        break;
                    default:
                        throw new NotImplementedException($"can't dump node of type '{anyNode.GetType().Name}'");
                }
            }
        }

        private void Dump(Nonterminal node)
        {
            w.wl($"{node}");
            w.indent(() =>
            {
                foreach (var child in node.Children)
                {
                    Dump(child);
                }
            });
        }

        private void Dump(Terminal node)
        {
            w.wl($"{node}");
        }

        private void Dump(Packed node)
        {
            w.wl($"{node}");
            w.indent(() =>
            {
                if (node.Left != null)
                {
                    Dump(node.Left);
                }
                Dump(node.Right);
            });
        }


        private void Dump(Intermediate node)
        {
            w.wl($"{node}");
            w.indent(() =>
            {
                foreach (var child in node.Children)
                {
                    Dump(child);
                }
            });
        }
    }
}
