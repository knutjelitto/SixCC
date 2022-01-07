using Six.Core;
using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public class SppfBuilder
    {
        private readonly Source source;
        private readonly Parser parser;
        private readonly RuleIndex? ruleIndex;
        private readonly Dictionary<string, Node> cache;

        public SppfBuilder(Source source, Parser parser, RuleIndex? ruleIndex = null)
        {
            this.source = source;
            this.parser = parser;
            this.ruleIndex = ruleIndex;
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

        private Symbol? Build(Matcher matcher, Cursor start, Cursor end)
        {
            switch (matcher)
            {
                case StartRule match:
                    return BuildRule(Role.Start, match, start, end);
                case PlainRule match:
                    return BuildRule(Role.Rule, match, start, end);
                case DfaRule match:
                    return BuildRule(Role.Rule, match, start, end);
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
                case Keyword match:
                    return BuildKeyword(match, start, end);
                case Matchers.String match:
                    return BuildString(match, start, end);
                case Matchers.Range match:
                    return BuildRange(match, start, end);
                case Eof match:
                    return BuildEof(match, start, end);
                case Drop match:
                    return BuildDrop(match, start, end);
                case Lift match:
                    return BuildLift(match, start, end);
                case Not:
                    // drop from film set
                    return null;
                default:
                    throw new NotImplementedException($"can't build node for '{matcher.GetType().Name}'");
            }
        }

        private Symbol? BuildRule(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out _))
            {
                if (matcher.IsTerminal)
                {
                    return BuildTerminal(matcher, start, end);
                }
                else
                {
                    return BuildNonterminal(role, matcher, start, end);
                }
            }

            return null;
        }

        private Symbol? BuildSeq(Seq matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            return NewNonterminal(Role.Seq, matcher, start, end, packeds);
        }

        private Symbol? BuildOptional(Optional matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            return NewNonterminal(Role.Optional, matcher, start, end, packeds);
        }

        private Symbol? BuildAlt(Alt matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, out var context))
            {
                var children = (from alt in matcher.Matchers
                                where alt.TryContext(start, end, out _)
                                let child = Build(alt, start, end)
                                where child != null
                                select child).ToList();

                children = ReduceAlternates(children).ToList();

                if (children.Count == 1)
                {
                    return children[0];
                }

                if (children.Count > 1)
                {
                    var packeds = new List<Packed>();

                    foreach (var child in children)
                    {
                        Assert(child.Start == start);
                        Assert(child.End == end);

                        var packed = NewPacked(matcher, child);

                        packeds.Add(packed);
                    }

                    var intermediate = NewIntermediate(matcher, start, end, 0, packeds.ToArray());

                    return intermediate;
                }
            }

            return null;
        }

        private Symbol? BuildStar(Star matcher, Cursor start, Cursor end)
        {
            return BuildLoop(Role.Star, matcher, start, end);
        }

        private Symbol? BuildPlus(Plus matcher, Cursor start, Cursor end)
        {
            return BuildLoop(Role.Plus, matcher, start, end);
        }

        private Symbol? BuildLoop(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                var repeat = matcher[0];
                var packeds = new List<Packed>();

                foreach (var partition in LoopPartitions(context, repeat, start, end))
                {
                    Node? result = null;

                    for (var i = 0; i < partition.Count; i++)
                    {
                        var extent = partition[i];

                        var next = Build(repeat, extent.Start, extent.End);

                        Assert(next != null);

                        if (result != null)
                        {
                            var packed = NewPacked(matcher, result, next);
                            result = NewIntermediate(matcher, result.Start, next.End, i + 1, packed);
                        }
                        else
                        {
                            result = next;
                        }
                    }

                    if (result != null)
                    {
                        Assert(result.Start == start);
                        Assert(result.End == end);

                        var packed = NewPacked(matcher, result);
                        packeds.Add(packed);
                    }
                }

                return NewNonterminal(role, matcher, start, end, packeds);
            }

            return null;
        }

        private IEnumerable<Packed> BuildMatcher(Matcher matcher, Cursor start, Cursor end)
        {
            return FindPartitions(matcher, start, end);
        }

        private IEnumerable<Packed> BuildPackedPartitioned(Matcher matcher, int dot, Extend[] partition)
        {
            Assert(matcher.Count == partition.Length);

            if (dot > 0)
            {
                dot--;

                var extend = partition[dot];

                var right = Build(matcher[dot], extend.Start, extend.End);

                if (right != null)
                {
                    if (dot == 0)
                    {
                        Assert(right.Start == extend.Start);
                        Assert(right.End == extend.End);

                        yield return NewPacked(matcher, right);
                    }
                    else
                    {
                        var left = BuildLeftPartitioned(matcher, dot - 1, partition);

                        if (left != null)
                        {
                            yield return NewPacked(matcher, left, right);
                        }
                    }
                }
            }
        }

        private Node? BuildLeftPartitioned(Matcher matcher, int dot, Extend[] partition)
        {
            if (dot == 0)
            {
                var extend = partition[dot];

                var left = Build(matcher[dot], extend.Start, extend.End);

                return left;
            }
            else
            {
                var left = BuildLeftPartitioned(matcher, dot - 1, partition);

                if (left != null)
                {
                    Assert(left.Start == partition[0].Start);
                    Assert(left.End == partition[dot - 1].End);

                    var extend = partition[dot];

                    var right = Build(matcher[dot], extend.Start, extend.End);

                    if (right != null)
                    {
                        Assert(right.End == extend.End);

                        var packed = NewPacked(matcher, left, right);

                        var intermediate = NewIntermediate(matcher, packed.Start, packed.End, dot + 1, packed);

                        Assert(intermediate.Start == packed.Start);
                        Assert(intermediate.End == packed.End);

                        return intermediate;
                    }
                }
            }

            return null;
        }

        private IEnumerable<List<Extend>> LoopPartitions(Context loopContext, Matcher repeat, Cursor start, Cursor end)
        {
            if (start >= end)
            {
                yield return new List<Extend>();
            }
            else
            {
                if (repeat.TryContext(start, out var repContext))
                {
                    foreach (var next in repContext.Nexts)
                    {
                        var extend = new Extend(start, next);

                        foreach (var nextPartition in LoopPartitions(loopContext, repeat, next, end))
                        {
                            var list = Enumerable.Repeat(extend, 1).Concat(nextPartition).ToList();
                            yield return list;
                        }
                    }
                }
            }
        }

        private IEnumerable<Packed> FindPartitions(Matcher matcher, Cursor start, Cursor end)
        {
            var extends = new Extend[matcher.Count];

            return Partitions(0, start, end);

            IEnumerable<Packed> Partitions(int dot, Cursor start, Cursor end)
            {
                Assert(dot >= 0 && dot <= matcher.Count);

                if (dot == matcher.Count)
                {
                    if (start == end)
                    {
                        var partials = BuildPackedPartitioned(matcher, matcher.Count, extends);

                        foreach (var partial in partials)
                        {
                            Assert(partial.End == end);
                            yield return partial;
                        }
                    }
                }
                else
                {
                    if (matcher[dot].TryContext(start, out var context))
                    {
                        foreach (var next in context.Nexts.Where(x => x <= end))
                        {
                            extends[dot] = new Extend(start, next);

                            foreach (var packed in Partitions(dot + 1, next, end))
                            {
                                yield return packed;
                            }
                        }
                    }
                }
            }
        }
        private Symbol? BuildDrop(Drop matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            return NewNonterminal(Role.Drop, matcher, start, end, packeds);
        }

        private Symbol? BuildLift(Lift matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            return NewNonterminal(Role.Lift, matcher, start, end, packeds);
        }

        private Symbol? BuildEof(Eof matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildCharacter(Character matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildString(Matchers.String matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildKeyword(Keyword matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildRange(Matchers.Range matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildTerminal(Matcher matcher, Cursor start, Cursor end)
        {
            if (matcher.TryContext(start, end, out var context))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Symbol? BuildNonterminal(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            var packeds = BuildMatcher(matcher, start, end).ToArray();

            Index(role, matcher, start, end);

            return NewNonterminal(role, matcher, start, end, packeds);
        }

        private Terminal NewTerminal(Matcher matcher, Cursor start, Cursor core, Cursor end)
        {
            Assert(start <= core && core <= end);
            var key = Terminal.Key(matcher, start, end);

            return Cache(key, () => new Terminal(matcher, start, core, end, source));
        }

        private Nonterminal NewNonterminal(Role role, Matcher matcher, Cursor start, Cursor end, IEnumerable<Packed> nodes)
        {
            return NewNonterminal(role, matcher, start, end, nodes.ToArray());
        }

        private Nonterminal NewNonterminal(Role role, Matcher matcher, Cursor start, Cursor end, params Packed[] nodes)
        {
            var key = Nonterminal.Key(role, matcher, start, end);

            if (nodes.Length == 1 && nodes[0].Left == null)
            {
                return Cache(key, () => new Nonterminal(role, matcher, start, end, nodes[0].Right));
            }
            else
            {
                return Cache(key, () => new Nonterminal(role, matcher, start, end, nodes));
            }
        }

        private static Intermediate NewIntermediate(Matcher matcher, Cursor start, Cursor end, int dot, params Packed[] nodes)
        {
            return new Intermediate(matcher, start, end, dot, nodes);
        }

        private static Packed NewPacked(Matcher matcher, Node left, Node right)
        {
            return new Packed(matcher, left.Start, right.End, left.End, left, right);
        }

        private static Packed NewPacked(Matcher matcher, Node right)
        {
            return new Packed(matcher, right.Start, right.End, right.Start, null, right);
        }

        private void Index(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            if (ruleIndex != null)
            {
                if (role == Role.Rule)
                {
                    var name = matcher.Name;
                    var location = start.Source.Report(start.Offset, end.Offset);
                    ruleIndex.Add(name, location);
                }
            }
        }

        /********** policies */

        private static IEnumerable<Symbol> ReduceAlternates(List<Symbol> nodes)
        {
            if (nodes.Count >= 2)
            {
                Assert(true);
            }
#if true
            return nodes;
#else
            //
            // strange policy:
            //   select first alternate
            //
            return Enumerable.Repeat(nodes.First(), 1);
#endif
        }
    }
}
