using Six.Core;
using System.Runtime.CompilerServices;

namespace Six.Runtime.Sppf
{
    public class SppfDumper : WithWriter
    {
        private readonly HashSet<Node> cache = new(new NodeEquals());
        public SppfDumper(Symbol root, Writer writer)
            : base(writer)
        {
            Root = root;
            cache = new();
        }

        public Symbol Root { get; }

        public static void Dump(Symbol root, Writer writer)
        {
            new SppfDumper(root, writer).Dump();
        }

        public void Dump()
        {
            Dump(Root);
        }

        private void Dump(Node anyNode)
        {
            if (cache.Contains(anyNode))
            {
                wl($"=> {anyNode}");
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
            wl($"{node}");
            indent(() =>
            {
                foreach (var child in node.Children)
                {
                    Dump(child);
                }
            });
        }

        private void Dump(Terminal node)
        {
            wl($"{node}");
        }

        private void Dump(Packed node)
        {
            wl($"{node}");
            indent(() =>
            {
                if (node.Left == null)
                {
                    wl("<null>");
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
            wl($"{node}");
            indent(() =>
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
