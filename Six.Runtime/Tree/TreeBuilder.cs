using Six.Core;
using Six.Runtime.Matchers;

//#pragma warning disable CA1822 // Mark members as static

namespace Six.Runtime.Tree
{
    public class TreeBuilder
    {
        private readonly Source source;
        private readonly ParserCore parser;
        private readonly Dictionary<string, Node> cache;

        public TreeBuilder(Source source, ParserCore parser)
        {
            this.source = source;
            this.parser = parser;
            cache = new();
        }

        public void Build()
        {
            var root = Build(parser.__Core.__Start, new Cursor(source, 0), new Cursor(source, source.Length), true).ToList();

            var file = Path.GetFileNameWithoutExtension(source.Name);
            using (var writer = $"{parser.__Name}-{file}-sppf.txt".Writer())
            {
                foreach (var node in root)
                {
                    new TreeDumper(node, writer).Dump();
                }
            }
        }

        private T Cache<T>(string key, Func<T> create)
            where T : Node
        {
#if false
            return create();
#else
            if (cache.TryGetValue(key, out var already))
            {
                return (T)already;
            }
            var node = create();
            cache.Add(key, node);
            return node;
#endif
        }

        private IEnumerable<Node> Build(Matcher matcher, Cursor start, Cursor ultimo, bool hard)
        {
            switch (matcher)
            {
                case StartRule match:
                    return BuildStartRule(match, start, ultimo, hard).ToArray();
                case PlainRule match:
                    return BuildPlainRule(match, start, ultimo, hard).ToArray();
                case Alt match:
                    return BuildAlt(match, start, ultimo, hard).ToArray();
                case Seq match:
                    return BuildSeq(match, start, ultimo, hard).ToArray();
                case Star match:
                    return BuildStar(match, start, ultimo, hard).ToArray();
                case Optional match:
                    return BuildOptional(match, start, ultimo, hard).ToArray();
                case Character match:
                    return BuildCharacter(match, start, ultimo, hard).ToArray();
                default:
                    throw new NotImplementedException($"can't build node for '{matcher.GetType().Name}'");
            }
        }

        private IEnumerable<Node> BuildStartRule(StartRule rule, Cursor start, Cursor end, bool hard)
        {
            var build = BuildRule(rule, start, end, hard);

            foreach (var node in build)
            {
                if (node.End == end)
                {
                    yield return node;
                }
            }
        }

        private IEnumerable<Node> BuildPlainRule(PlainRule rule, Cursor start, Cursor ultimo, bool hard)
        {
            return BuildRule(rule, start, ultimo, hard);
        }

        private IEnumerable<Node> BuildRule(Rule rule, Cursor start, Cursor ultimo, bool hard)
        {
            if (Covers(rule, start))
            {
                if (rule.IsTerminal)
                {
                    return BuildTerminal(rule, start, ultimo, hard).ToArray();
                }
                else
                {
                    return BuildNonterminal(rule, start, ultimo, hard).ToArray();
                }
            }

            return Enumerable.Empty<Node>();
        }

        private IEnumerable<Node> BuildAlt(Alt matcher, Cursor start, Cursor ultimo, bool hard)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                foreach (var alt in matcher.Matchers)
                {
                    if (CanMatch(alt, start, ultimo))
                    {
                        foreach (var node in Build(alt, start, ultimo, hard).ToArray())
                        {
                            if (node.End <= ultimo)
                            {
                                yield return node;
                            }
                        }
                    }
                }
            }
        }

        private IEnumerable<Node> BuildSeq(Seq matcher, Cursor start, Cursor ultimo, bool hard)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                var children = BuildPacked(matcher, matcher.Count, start, ultimo, hard).ToArray();

                foreach (var (end, packed) in Groups(children))
                {
                    var nonterminal = NewNonterminal(start, end, matcher, packed);

                    yield return nonterminal;
                }
            }
        }

        private IEnumerable<Node> BuildStar(Star matcher, Cursor start, Cursor ultimo, bool hard)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                if (start == ultimo)
                {
                    var nonterminal = NewNonterminal(start, ultimo, matcher);

                    yield return nonterminal;
                }
                else
                {
                    var children = BuildPacked(matcher, matcher.Count, start, ultimo, hard).ToArray();

                    foreach (var (end, packeds) in Groups(children).ToArray())
                    {
                        Assert(end <= ultimo);

                        var nonterminal = NewNonterminal(start, end, matcher, packeds);

                        yield return nonterminal;

                        if (end < ultimo)
                        {
                            var mores = BuildStar(matcher, end, ultimo, hard).ToArray();

                            foreach (var more in mores)
                            {
                                var packed = NewPacked(start, more.End, matcher, end, nonterminal, more);

                                var longer = NewNonterminal(start, more.End, matcher, packed);

                                yield return longer;
                            }
                        }
                    }
                }

            }
        }

        private IEnumerable<Node> BuildOptional(Optional matcher, Cursor start, Cursor ultimo, bool hard)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                var children = BuildPacked(matcher, matcher.Count, start, ultimo, hard).ToArray();

                foreach (var (end, nodes) in Groups(children))
                {
                    var nonterminal = NewNonterminal(start, end, matcher, nodes);

                    yield return nonterminal;
                }
            }
        }

        private IEnumerable<Node> BuildCharacter(Character matcher, Cursor start, Cursor ultimo, bool hard)
        {
            var context = matcher.Context(start);

            if (context != null && start + 1 <= ultimo)
            {
                Assert(context.Nexts.Count == 1);
                Assert(context.Nexts.First().Offset == start.Offset + 1);
                Assert(context.Nexts.First().Offset <= ultimo.Offset);

                var chr = NewTerminal(start, start + 1, matcher);

                yield return chr;
            }
        }

        private IEnumerable<Node> BuildTerminal(Matcher matcher, Cursor start, Cursor ultimo, bool hard)
        {
            Assert(matcher.IsTerminal);
            Assert(Covers(matcher, start));

            var context = matcher.Context(start);
            if (context != null)
            {
                foreach (var next in context.Nexts.OrderBy(x => x.Offset))
                {
                    if (next <= ultimo)
                    {
                        yield return NewTerminal(start, next, matcher);
                    }
                }
            }
        }

        private IEnumerable<Node> BuildNonterminal(Rule matcher, Cursor start, Cursor ultimo, bool hard)
        {
            Assert(!matcher.IsTerminal);
            Assert(Covers(matcher, start));

            var key = Nonterminal.Key(start, ultimo, matcher);

            if (cache.TryGetValue(key, out var node))
            {
                yield return node;
            }
            else
            {
                var context = matcher.Context(start);

                if (context != null)
                {
                    var children = BuildPacked(matcher, matcher.Matchers.Length, start, ultimo, hard).ToArray();

                    foreach (var (end, nodes) in Groups(children))
                    {
                        yield return NewNonterminal(start, end, matcher, nodes);
                    }
                }
            }
        }

        private IEnumerable<Node> BuildPackedLeft(Matcher matcher, int dot, Cursor start, Cursor ultimo, bool hard)
        {
            if (dot == 0)
            {
                yield break;
            }
            else if (dot == 1)
            {
                var before = matcher.Matchers[dot - 1];
                var context = before.Context(start);
                if (context != null)
                {
                    var already = new HashSet<Cursor>();

                    foreach (var next in context.Nexts.OrderBy(x => x.Offset))
                    {
                        if (next <= ultimo)
                        {
                            var symbols = Build(before, start, next, hard).ToArray();

                            foreach (var symbol in symbols)
                            {
                                if (!already.Contains(symbol.End))
                                {
                                    already.Add(symbol.End);
                                    yield return symbol;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var intermediate in BuildIntermediate(matcher, dot, start, ultimo, hard).ToArray())
                {
                    yield return intermediate;
                }
            }            
        }

        private IEnumerable<Packed> BuildPacked(Matcher matcher, int dot, Cursor start, Cursor ultimo, bool hard)
        {
            Assert(dot > 0);
            Assert(Covers(matcher, start));
            Assert(matcher.Matchers.Length > 0);

            if (dot <= matcher.Count)
            {
                var lefts = BuildPackedLeft(matcher, dot, start, ultimo, hard).ToArray();

                foreach (var left in lefts)
                {
                    Assert(left.End <= ultimo);

                    if (dot < matcher.Count)
                    {
                        var rights = Build(matcher.Matchers[dot], left.End, ultimo, hard).ToArray();

                        foreach (var right in rights)
                        {
                            var packed = NewPacked(start, right.End, matcher, right.Start, left, right);

                            yield return packed;
                        }
                    }
                    else
                    {
                        var packed = NewPacked(start, left.End, matcher, left.Start, null, left);

                        yield return packed;
                    }
                }
            }
        }

        private IEnumerable<Intermediate> BuildIntermediate(Matcher matcher, int dot, Cursor start, Cursor ultimo, bool hard)
        {
            Assert(dot >= 2);

            var children = BuildPacked(matcher, dot - 1, start, ultimo, hard).ToArray();

            foreach (var (end, nodes) in Groups(children))
            {
                var inter = NewIntermediate(start, end, matcher, dot, nodes);

                yield return inter;
            }
        }

        private Terminal NewTerminal(Cursor start, Cursor end, Matcher matcher)
        {
            var key = Terminal.Key(start, end, matcher);

            return Cache(key, () => new Terminal(start, end, matcher, source));
        }

        private Nonterminal NewNonterminal(Cursor start, Cursor end, Matcher matcher, params Packed[] nodes)
        {
            var key = Nonterminal.Key(start, end, matcher);

            if (nodes.Length == 1 && nodes[0].Left == null && false)
            {
                return Cache(key, () => new Nonterminal(start, end, matcher, nodes[0].Right));
            }
            else
            {
                return Cache(key, () => new Nonterminal(start, end, matcher, nodes));
            }
        }

        private Intermediate NewIntermediate(Cursor start, Cursor end, Matcher matcher, int dot, params Packed[] nodes)
        {
            var key = Intermediate.Key(start, end, matcher, dot);

            return Cache(key, () => new Intermediate(start, end, matcher, dot, nodes));
        }

        private static Packed NewPacked(Cursor start, Cursor end, Matcher matcher, Cursor pivot, Node? left, Node right)
        {
            return new Packed(start, end, matcher, pivot, left, right);
        }


        private static IEnumerable<(Cursor end, N[] nodes)> Groups<N>(N[] nodes)
            where N : Node
        {
            var groups = from p in nodes
                         group p by p.End into grouped
                         orderby grouped.Key.Offset
                         select (end: grouped.Key, nodes: grouped.ToArray());

            return groups;
        }

        /********** helpers */

        [DebuggerStepThrough]
        private static bool Covers(Matcher matcher, Cursor start)
        {
            return matcher.Contexts.ContainsKey(start);
        }

        private static bool CanMatch(Matcher matcher, Cursor start, Cursor ultimo)
        {
            var context = matcher.Context(start);

            return context != null && context.Nexts.Select(x => x.Offset).Min() <= ultimo.Offset;
        }
    }
}
