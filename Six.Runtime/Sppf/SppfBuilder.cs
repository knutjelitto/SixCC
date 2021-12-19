using Six.Core;
using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public class SppfBuilder
    {
        private readonly Source source;
        private readonly ParserCore parser;
        private readonly Dictionary<string, Node> cache;

        public SppfBuilder(Source source, ParserCore parser)
        {
            this.source = source;
            this.parser = parser;
            cache = new();
        }

        public Nonterminal? BuildSppf()
        {
            var node = Build(parser.__Core.__Start, new Cursor(source, 0), new Cursor(source, source.Length));

            if (node is Nonterminal root)
            {
                return root;
            }

            return null;
        }

        private T Cache<T>(string key, Func<T> create)
            where T : Symbol
        {
            if (cache.TryGetValue(key, out var already))
            {
                return (T)already;
            }
            var node = create();
            cache.Add(key, node);
            return node;
        }

        private Node? Build(Matcher matcher, Cursor start, Cursor end)
        {
            switch (matcher)
            {
                case StartRule match:
                    return BuildStartRule(match, start, end);
                case PlainRule match:
                    return BuildPlainRule(match, start, end);
                case DfaRule match:
                    return BuildDfaRule(match, start, end);
                case Alt match:
                    return BuildAlt(match, start, end);
                case Seq match:
                    return BuildSeq(match, start, end);
                case Star match:
                    return BuildStar(match, start, end);
                case Plus match:
                    return BuildPlus(match, start, end);
                case Optional match:
                    return BuildOptional(match, start, end);
                case Character match:
                    return BuildCharacter(match, start, end);
                case Matchers.String match:
                    return BuildString(match, start, end);
                case Matchers.Range match:
                    return BuildRange(match, start, end);
                default:
                    throw new NotImplementedException($"can't build node for '{matcher.GetType().Name}'");
            }
        }

        private Node? BuildStartRule(StartRule rule, Cursor start, Cursor end)
        {
            return BuildRule(Role.Start, rule, start, end);
        }

        private Node? BuildPlainRule(PlainRule rule, Cursor start, Cursor end)
        {
            return BuildRule(Role.Rule, rule, start, end);
        }

        private Node? BuildDfaRule(DfaRule rule, Cursor start, Cursor end)
        {
            return BuildRule(Role.Rule, rule, start, end);
        }

        private Node? BuildRule(Role role, Rule rule, Cursor start, Cursor end)
        {
            if (CanMatch(rule, start, end))
            {
                if (rule.IsTerminal)
                {
                    return BuildTerminal(rule, start, end);
                }
                else
                {
                    return BuildNonterminal(role, rule, start, end);
                }
            }

            return null;
        }

        private Node? BuildSeq(Seq matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            var nonterminal = NewNonterminal(Role.Seq, matcher, start, end, packeds);

            return nonterminal;
        }

        private Node? BuildOptional(Optional matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                var packeds = BuildMatcher(matcher, start, end).ToArray();

                var optional = NewNonterminal(Role.Optional, matcher, start, end, packeds);

                return optional;
            }

            return null;
        }

        private Node? BuildAlt(Alt matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null)
            {
                var children = (from alt in matcher
                                where CanMatch(alt, start, end)
                                let child = Build(alt, start, end)
                                where child != null
                                select child).ToList();

                if (children.Count == 1)
                {
                    return children[0];
                }

                if (children.Count > 1)
                {
                    var packeds = new List<Packed>();

                    foreach (var child in children)
                    {
                        var packed = NewPacked(matcher, start, end, child);

                        packeds.Add(packed);
                    }

                    return NewNonterminal(Role.Alt, matcher, start, end, packeds.ToArray());
                }
            }

            return null;
        }

        private Node? BuildStar(Star matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && CanMatch(matcher, start, end))
            {
                var repeat = matcher[0];
                var packeds = new List<Packed>();

                foreach (var partition in StarPartitions(context, repeat, start, end))
                {
                    Node? result = null;

                    for (var i = 0; i < partition.Count; i++)
                    {
                        var extent = partition[i];

                        var next = Build(repeat, extent.Start, extent.End);

                        Assert(next != null);

                        if (result != null)
                        {
                            var packed = NewPacked(matcher, result.Start, next.End, result.End, result, next);
                            result = NewIntermediate(matcher, result.Start, next.End, i + 1, packed);
                        }
                        else
                        {
                            result = next;
                        }
                    }

                    if (result != null)
                    {
                        var packed = NewPacked(matcher, start, end, result);
                        packeds.Add(packed);
                    }
                }

                var star = NewNonterminal(Role.Star, matcher, start, end, packeds.ToArray());

                return star;
            }

            return null;
        }

        private IEnumerable<List<Extend>> StarPartitions(Context starContext, Matcher repeat, Cursor start, Cursor end)
        {
            if (start >= end)
            {
                yield return new List<Extend>();
            }
            else
            {
                var repContext = repeat.Context(start)!;

                foreach (var next in repContext.Nexts)
                {
                    var extend = new Extend(start, next);

                    foreach (var nextPartition in StarPartitions(starContext, repeat, next, end))
                    {
                        var list = Enumerable.Repeat(extend, 1).Concat(nextPartition).ToList();
                        yield return list;
                    }
                }
            }
        }

        private Node? BuildPlus(Plus matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            Node? result = null;

            if (context != null && CanMatch(matcher, start, end))
            {
                var repeat = matcher[0];

                var partition = new List<Cursor>
                    {
                        start
                    };
                partition.AddRange(context.Nexts.Where(x => x <= end));

                for (var i = 0; i < partition.Count - 1; i++)
                {
                    if (!CanMatch(repeat, partition[i], partition[i + 1]))
                    {
                        partition.RemoveAt(i);
                    }
                }
                for (var i = 0; i < partition.Count - 1; i++)
                {
                    var next = Build(repeat, partition[i], partition[i + 1]);

                    Assert(next != null);

                    if (result != null)
                    {
                        var packed = NewPacked(matcher, result.Start, next.End, result.End, result, next);
                        result = NewIntermediate(matcher, result.Start, partition[i + 1], i + 1, packed);
                    }
                    else
                    {
                        result = next;
                    }
                }

                Assert(result != null);

                if (result == null)
                {
                    result = NewNonterminal(Role.Plus, matcher, start, end);
                }
                else
                {
                    var packed = NewPacked(matcher, start, end, result);
                    result = NewNonterminal(Role.Plus, matcher, start, end, packed);
                }
            }

            return result;
        }

        private IEnumerable<Packed> BuildMatcher(Matcher matcher, Cursor start, Cursor end)
        {
            var partitions = FindPartitions(matcher, 0, start, end).ToList();

            var packeds = new List<Packed>();

            foreach (var partition in partitions)
            {
                var partials = BuildPackedPartitioned(matcher, matcher.Count, partition).ToList();

                foreach (var partial in partials)
                {
                    Assert(partial.End == end);
                    packeds.Add(partial);
                }
            }

            return packeds;
        }

        private IEnumerable<Packed> BuildPackedPartitioned(Matcher matcher, int dot, List<Cursor> partition)
        {
            Assert(matcher.Count + 1 == partition.Count);

            if (dot > 0)
            {
                dot--;

                var right = Build(matcher[dot], partition[dot], partition[dot + 1]);

                if (right != null)
                {
                    if (dot == 0)
                    {
                        Assert(right.Start == partition[dot]);
                        Assert(right.End == partition[dot + 1]);

                        if (right is Nonterminal nonterminal && nonterminal.Role == Role.Alt)
                        {
                            foreach (var node in nonterminal.Children.Cast<Packed>())
                            {
                                yield return node;
                            }
                        }
                        else
                        {
                            yield return NewPacked(matcher, partition[dot], partition[dot + 1], partition[dot], null, right);
                        }
                    }
                    else
                    {
                        var left = BuildLeftPartitioned(matcher, dot, partition);

                        if (left != null)
                        {
                            yield return NewPacked(matcher, left.Start, right.End, left.End, left, right);
                        }
                    }
                }
            }
        }

        private Node? BuildLeftPartitioned(Matcher matcher, int dot, List<Cursor> partition)
        {
            Assert(dot > 0);

            dot--;

            if (dot == 0)
            {
                var left = Build(matcher[dot], partition[dot], partition[dot + 1]);

                return left;
            }
            else
            {
                var left = BuildLeftPartitioned(matcher, dot, partition);

                if (left != null)
                {
                    Assert(left.Start == partition[0]);
                    Assert(left.End == partition[dot]);

                    var right = Build(matcher[dot], partition[dot], partition[dot + 1]);

                    if (right != null)
                    {
                        Assert(right.End == partition[dot + 1]);

                        var packed = NewPacked(matcher, left.Start, right.End, left.End, left, right);

                        var intermediate = NewIntermediate(matcher, partition[dot - 1], partition[dot + 1], dot + 1, packed);

                        return intermediate;
                    }
                }
            }

            return null;
        }

        private IEnumerable<List<Cursor>> FindPartitions(Matcher symbol, int dot, Cursor start, Cursor end)
        {
            Assert(dot < symbol.Count);

            if (dot < symbol.Count)
            {
                var matcher = symbol[dot];

                var context = matcher.Context(start);

                if (context != null)
                {
                    if (dot + 1 == symbol.Count)
                    {
                        if (context.Nexts.Contains(end))
                        {
                            yield return new List<Cursor> { start, end };
                        }
                    }
                    else
                    {
                        foreach (var next in context.Nexts.Where(x => x <= end).ToList())
                        {
                            if (next <= end)
                            {
                                foreach (var sub in FindPartitions(symbol, dot + 1, next, end).ToList())
                                {
                                    var list = new List<Cursor>
                                    {
                                        start
                                    };
                                    list.AddRange(sub);

                                    yield return list;
                                }
                            }
                        }
                    }
                }
            }
        }

        private Node? BuildCharacter(Character matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && context.Nexts.Contains(end))
            {
                var chr = NewTerminal(matcher, start, context.Core, end);

                return chr;
            }

            return null;
        }

        private Node? BuildString(Matchers.String matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && context.Nexts.Contains(end))
            {
                var chr = NewTerminal(matcher, start, context.Core, end);

                return chr;
            }

            return null;
        }

        private Node? BuildRange(Matchers.Range matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && context.Nexts.Contains(end))
            {
                var chr = NewTerminal(matcher, start, context.Core, end);

                return chr;
            }

            return null;
        }

        private Node? BuildTerminal(Matcher matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && context.Nexts.Contains(end))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Node? BuildNonterminal(Role role, Rule matcher, Cursor start, Cursor end)
        {
            Assert(!matcher.IsTerminal);
            Assert(Covers(matcher, start));

            var context = matcher.Context(start);

            if (context != null)
            {
                if (matcher is StartRule startRule)
                {
                    end = startRule.White!.Value;
                }
                var children = BuildMatcher(matcher, start, end).ToArray();

                foreach (var packed in children)
                {
                    Assert(packed.End == end);
                }

                return NewNonterminal(role, matcher, start, end, children);
            }

            return null;
        }

        private Terminal NewTerminal(Matcher matcher, Cursor start, Cursor core, Cursor end)
        {
            Assert(core >= start && core < end);
            var key = Terminal.Key(matcher, start, end);

            return Cache(key, () => new Terminal(matcher, start, core, end, source));
        }

        private Nonterminal NewNonterminal(Role role, Matcher matcher, Cursor start, Cursor end, params Packed[] nodes)
        {
            var key = Nonterminal.Key(role, matcher, start, end);

            if (nodes.Length == 1 && nodes[0].Left == null && true)
            {
                return Cache(key, () => new Nonterminal(role, matcher, start, end, nodes[0].Right));
            }
            else
            {
                return Cache(key, () => new Nonterminal(role, matcher, start, end, nodes));
            }
        }

        private Intermediate NewIntermediate(Matcher matcher, Cursor start, Cursor end, int dot, params Packed[] nodes)
        {
            return new Intermediate(matcher, start, end, dot, nodes);
        }

        private static Packed NewPacked(Matcher matcher, Cursor start, Cursor end, Cursor pivot, Node? left, Node right)
        {
            return new Packed(matcher, start, end, pivot, left, right);
        }

        private static Packed NewPacked(Matcher matcher, Cursor start, Cursor end, Node right)
        {
            return new Packed(matcher, start, end, start, null, right);
        }

        /********** helpers */

        [DebuggerStepThrough]
        private static bool Covers(Matcher matcher, Cursor start)
        {
            return matcher.Contexts.ContainsKey(start);
        }

        [DebuggerStepThrough]
        private static bool CanMatch(Matcher matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            return context != null && context.Nexts.Contains(end);
        }
    }
}
