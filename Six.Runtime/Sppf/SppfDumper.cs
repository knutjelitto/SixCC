using Six.Core;
using System.Runtime.CompilerServices;

namespace Six.Runtime.Sppf
{
#pragma warning disable IDE1006 // Naming Styles
    public class SppfDumper : IWithWriter
    {
        private readonly HashSet<Node> cache = new(new NodeEquals());
        public SppfDumper(Symbol root, Writer writer)
        {
            Root = root;
            Writer = writer;
            cache = new();
        }

        public Symbol Root { get; }
        public Writer Writer { get; }

        protected IWithWriter w => this;

        public void Dump()
        {
            Dump(Root);
        }
        private void Dump(Node anyNode)
        {
            if (cache.Contains(anyNode))
            {
                w.wl($"=> {anyNode}");
            }
            else
            {
                if (anyNode is not Packed)
                {
                    cache.Add(anyNode);
                }
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
                if (node.Left == null)
                {
                    w.wl("<null>");
                }
                else
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

        private class NodeEquals : IEqualityComparer<Node>
        {
            public bool Equals(Node? x, Node? y)
            {
                return ReferenceEquals(x, y);
            }

            public int GetHashCode([DisallowNull] Node obj)
            {
                return RuntimeHelpers.GetHashCode(obj);
            }
        }
    }
}
