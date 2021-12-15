using Six.Core;

namespace Six.Runtime.Sppf
{
#pragma warning disable IDE1006 // Naming Styles
    public class SppfDumper : IWithWriter
    {
        private readonly Dictionary<string, Node> cache;
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

        private IEnumerable<string> Content(Node anyNode)
        {
            throw new NotImplementedException();
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
                if (anyNode is not Packed)
                {
                    cache.Add(key, anyNode);
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
    }
}
