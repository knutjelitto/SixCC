using SixCC.Writing;

namespace SixCC.Sdk.Earley
{
    internal sealed class ForrestDot
    {
        public ForrestDot(Writer writer, CoreNode root)
        {
            Writer = writer;
            Root = root;
        }

        public Writer Writer { get; }
        public CoreNode Root { get; }

        private class NodeById : IEqualityComparer<CoreNode>
        {
            public bool Equals(CoreNode? x, CoreNode? y)
            {
                return x != null && y != null && x.Id == y.Id;
            }

            public int GetHashCode([DisallowNull] CoreNode node)
            {
                return node.Id.GetHashCode();
            }
        }

        public void Dot()
        {
            var nodes = new Queue<CoreNode>();
            var edges = new Queue<(CoreNode from, CoreNode to)>();
            var already = new HashSet<CoreNode>(new NodeById());
            var more = false;
            var root = Root;
            if (root.Children.Count == 1)
            {
                root = root.Children[0]!;
            }
            already.Add(root);
            nodes.Enqueue(root);

            Writer.WriteLine("digraph");
            Writer.WriteLine("{");
            using (Writer.Indent())
            {
                Writer.WriteLine("rankdir = TB;");
                Writer.WriteLine("subgraph");
                Writer.WriteLine("{");
                using (Writer.Indent())
                {
                    while (nodes.Count > 0)
                    {
                        var node = nodes.Dequeue();
                        if (more)
                        {
                            Writer.WriteLine();
                        }
                        more = true;
                        Writer.WriteLine($"{node.Id()}");
                        using (Writer.Indent())
                        {
                            if (node is RootNode)
                            {
                                Writer.WriteLine($"[label=\"\"]");
                                Writer.WriteLine($"[shape=square]");
                                Writer.WriteLine($"[width=0.18]");
                            }
                            else if (node is NonterminalNode non)
                            {
                                Writer.WriteLine($"[label=\"({non.Symbol},{non.Start},{non.Next})-{non.Key}\"]");
                                Writer.WriteLine($"[shape=rectangle]");
                                Writer.WriteLine($"[style=rounded]");
                            }
                            else if (node is TerminalNode term)
                            {
                                Writer.WriteLine($"[label=\"({term.Symbol},{term.Start},{term.Next})\"]");
                                Writer.WriteLine($"[shape=hexagon]");
                            }
                            else if (node is IntermediateNode inter)
                            {
                                Writer.WriteLine($"[label=\"({inter.Symbol},{inter.Start}..{inter.Next})-{inter.Key}\"]");
                                Writer.WriteLine($"[shape=rectangle]");
                            }
                            else if (node is PackedNode)
                            {
                                Writer.WriteLine($"[label=\"\"]");
                                Writer.WriteLine($"[shape=circle]");
                                Writer.WriteLine($"[width=0.2]");
                            }
                            else
                            {
                                Writer.WriteLine($"[label=\"{node}\"]");
                                Writer.WriteLine($"[width=1]");
                            }
                        }
                        foreach (var child in node.Children.Where(c => c != null).Select(c => c!))
                        {
                            edges.Enqueue((node, child));
                            if (!already.Contains(child))
                            {
                                already.Add(child);
                                nodes.Enqueue(child);
                            }
                        }
                        foreach (var (from, to) in edges)
                        {
                            Writer.WriteLine($"{from.Id()} -> {to.Id()}");
                        }
                        edges.Clear();
                    }
                    Writer.WriteLine();
                    Writer.WriteLine("{");
                    using (Writer.Indent())
                    {
                        Writer.WriteLine("rank = same;");
                        Writer.WriteLine("rankdir = LR;");
                        Writer.WriteLine("edge [style=invis];");
                        var terminals = already.OfType<TerminalNode>().OrderBy(t => t.Start).ThenBy(t => t.Next).Select(t => t.Id());
                        Writer.WriteLine($"{string.Join(" -> ", terminals)}");
                    }
                    Writer.WriteLine("}");
                }
                Writer.WriteLine("}");
            }
            Writer.WriteLine("}");
        }
    }
    internal static class NodeDumpExtensions
    {
        public static string Id(this CoreNode node)
        {
            return $"n{node.Id}";
        }
    }

}
