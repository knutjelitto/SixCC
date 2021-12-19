using Six.Core;

namespace Six.Runtime.Sppf
{
#pragma warning disable IDE1006 // Naming Styles
    public class SppfEnumerator : IWithWriter
    {
        public SppfEnumerator(Symbol root, Writer writer)
        {
            Root = root;
            Writer = writer;
        }

        public Symbol Root { get; }
        public bool Tree { get; }
        public Writer Writer { get; }

        protected IWithWriter w => this;

        public int Enum()
        {
            var count = 0;
            var items = Dump(string.Empty, Root).OrderBy(x => x).ToList();
            foreach (var tree in items)
            {
                w.wl($"{++count, 3}  {tree}");

                if (count == 1000)
                {
                    break;
                }
            }
            return count;
        }

        private IEnumerable<string> Dump(string prefix, Node anyNode)
        {
            switch (anyNode)
            {
                case Nonterminal node:
                    return Dump(prefix, node).ToList();
                case Terminal node:
                    return Dump(prefix, node).ToList();
                case Packed node:
                    return Dump(prefix, node).ToList();
                case Intermediate node:
                    return Dump(prefix, node).ToList();
                default:
                    throw new NotImplementedException($"can't dump node of type '{anyNode.GetType().Name}'");
            }
        }

        private IEnumerable<string> Dump(string prefix, Nonterminal node)
        {
            if (node.Role == Role.Seq)
            {
                if (node.Children.Length == 0)
                {
                    yield return $"{prefix})";
                }
                else
                {
                    foreach (var packed in node.Children)
                    {
                        foreach (var tree in Dump(prefix, packed))
                        {
                            yield return tree;
                        }
                    }
                }
            }
            else if (node.Role == Role.Star)
            {
                if (node.Children.Length == 0)
                {
                    yield return $"{prefix}*()";
                }
                else
                {
                    foreach (var child in node.Children)
                    {
                        foreach (var tree in Dump($"*(", child).ToList())
                        {
                            yield return $"{prefix}{tree})";
                        }
                    }
                }
            }
            else if (node.Role == Role.Plus)
            {
                if (node.Children.Length == 0)
                {
                    yield return $"{prefix}+()";
                }
                else
                {
                    foreach (var child in node.Children)
                    {
                        foreach (var tree in Dump($"+(", child).ToList())
                        {
                            yield return $"{prefix}{tree})";
                        }
                    }
                }
            }
            else if (node.Role == Role.Optional)
            {
                if (node.Children.Length == 0)
                {
                    yield return $"{prefix}?()";
                }
                else
                {
                    foreach (var child in node.Children)
                    {
                        foreach (var tree in Dump($"?(", child).ToList())
                        {
                            yield return $"{prefix}{tree})";
                        }
                    }
                }
            }
            else if (node.Role == Role.Rule)
            {
                foreach (var child in node.Children)
                {
                    foreach (var tree in Dump($"{node.Name}(", child).ToList())
                    {
                        yield return $"{prefix}{tree})";
                    }
                }
            }
            else if (node.Role == Role.Start)
            {
                foreach (var child in node.Children)
                {
                    foreach (var tree in Dump($"", child).ToList())
                    {
                        yield return $"{prefix}{tree}";
                    }
                }
            }
            else
            {
                throw new NotImplementedException($"can't dump nonterminal of role '{node.Role.ToString().ToLowerInvariant()}'");
            }
        }

        private static IEnumerable<string> Dump(string prefix, Terminal node)
        {
            var text = node.Source.GetText(node.Start.Offset, node.End.Offset - node.Start.Offset);
            var esc = text.Esc();

            if (esc != node.Name)
            {
                yield return $"{prefix}{node.Name}[{esc}]";
            }
            else
            {
                yield return $"{prefix}{node.Name}";
            }
        }

        private IEnumerable<string> Dump(string prefix, Packed node)
        {
            var ok = false;

            if (node.Left == null)
            {
                foreach (var right in Dump($"", node.Right).ToList())
                {
                    ok = true;
                    yield return $"{prefix}{right}";
                }
            }
            else
            {
                foreach (var left in Dump("", node.Left).ToList())
                {
                    foreach (var right in Dump(" ", node.Right).ToList())
                    {
                        ok = true;
                        yield return $"{prefix}{left}{right}";
                    }

                    Assert(ok);
                }

                Assert(ok);
            }

            if (!ok)
            {
                throw new InvalidOperationException();
            }
        }


        private IEnumerable<string> Dump(string prefix, Intermediate node)
        {
            foreach (var child in node.Children)
            {
                foreach (var tree in Dump("", child).ToList())
                {
                    yield return $"{prefix}{tree}";
                }
            }
        }
    }
}
