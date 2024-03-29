﻿using Six.Core;

namespace Six.Runtime.Sppf
{
    public class SppfEnumerator : WithWriter
    {
        public SppfEnumerator(Symbol root, Writer writer)
            : base(writer)
        {
            Root = root;
        }

        public Symbol Root { get; }
        public bool Tree { get; }

        public static int Count(Symbol root, Writer writer)
        {
            return new SppfEnumerator(root, writer).Count();
        }

        public int Count()
        {
            return Count(Root);
        }

        private int Count(Node anyNode)
        {
            switch (anyNode)
            {
                case Packed packed:
                    {
                        if (packed.Left == null)
                        {
                            return Count(packed.Right);
                        }
                        else
                        {
                            return Count(packed.Left) * Count(packed.Right);
                        }
                    }
                case Intermediate intermediate:
                    {
                        return Math.Max(1, intermediate.Children.Sum(child => Count(child)));
                    }
                case Nonterminal nonterminal:
                    {
                        return Math.Max(1, nonterminal.Children.Sum(child => Count(child)));
                    }
                case Terminal terminal:
                    {
                        return 1;
                    }
            }

            return -1;
        }

        public int Enum()
        {
            var count = 0;
            var items = Dump(string.Empty, Root);
            foreach (var tree in items)
            {
                wl($"{++count, 3}  {tree}");

                if (count == 2000)
                {
                    break;
                }
            }

            var distinct = items.Distinct().Count();

            Assert(count == distinct);

            return count;
        }

        private IEnumerable<string> Dump(string prefix, Node anyNode)
        {
            switch (anyNode)
            {
                case Nonterminal node:
                    return Dump(prefix, node);
                case Terminal node:
                    return Dump(prefix, node);
                case Packed node:
                    return Dump(prefix, node);
                case Intermediate node:
                    return Dump(prefix, node);
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
                        foreach (var tree in Dump($"*(", child))
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
                        foreach (var tree in Dump($"+(", child))
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
                        foreach (var tree in Dump($"?(", child))
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
                    foreach (var tree in Dump($"{node.Name}(", child))
                    {
                        yield return $"{prefix}{tree})";
                    }
                }
            }
            else if (node.Role == Role.Start)
            {
                foreach (var child in node.Children)
                {
                    foreach (var tree in Dump($"", child))
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
            var text = node.Source.GetText(node.Core.Offset, node.End.Offset - node.Core.Offset);
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
                foreach (var right in Dump($"", node.Right))
                {
                    ok = true;
                    yield return $"{prefix}{right}";
                }
            }
            else
            {
                foreach (var left in Dump("", node.Left))
                {
                    foreach (var right in Dump(" ", node.Right))
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
                foreach (var tree in Dump("", child))
                {
                    yield return $"{prefix}{tree}";
                }
            }
        }
    }
}
