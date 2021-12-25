﻿using Six.Core;
using Six.Runtime.Matchers;

#pragma warning disable IDE0028 // Simplify collection initialization

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
                case Matchers.Keyword match:
                    return BuildKeyword(match, start, end);
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
            if (rule.CanMatch(start, end))
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
                                where alt.CanMatch(start, end)
                                let child = Build(alt, start, end)
                                where child != null
                                select child).ToList();

                if (children.Count >= 2)
                {
                    Assert(true);
                }

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
                        var packed = NewPacked(matcher, start, end, child);

                        packeds.Add(packed);
                    }

                    var intermediate = NewIntermediate(matcher, start, end, 0, packeds.ToArray());

                    return intermediate;
                }
            }

            return null;
        }

        private Node? BuildStar(Star matcher, Cursor start, Cursor end)
        {
            return BuildLoop(Role.Star, matcher, start, end);
        }

        private Node? BuildPlus(Plus matcher, Cursor start, Cursor end)
        {
            return BuildLoop(Role.Plus, matcher, start, end);
        }

        private Node? BuildLoop(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            if (context != null && matcher.CanMatch(start, end))
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

                var loop = NewNonterminal(role, matcher, start, end, packeds);

                return loop;
            }

            return null;
        }

        private IEnumerable<List<Extend>> LoopPartitions(Context starContext, Matcher repeat, Cursor start, Cursor end)
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

                    foreach (var nextPartition in LoopPartitions(starContext, repeat, next, end))
                    {
                        var list = Enumerable.Repeat(extend, 1).Concat(nextPartition).ToList();
                        yield return list;
                    }
                }
            }
        }
        private IEnumerable<Packed> BuildMatcher(Matcher matcher, Cursor start, Cursor end)
        {
            var partitions = FindPartitions(matcher, 0, start, end).ToList();

            var packeds = new List<Packed>();

            foreach (var partition in partitions)
            {
                //Assert(partition.Count == partition.Distinct().Count());

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

                        yield return NewPacked(matcher, partition[dot], partition[dot + 1], partition[dot], null, right);
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

                        //var intermediate = NewIntermediate(matcher, partition[dot - 1], partition[dot + 1], dot + 1, packed);
                        var intermediate = NewIntermediate(matcher, packed.Start, packed.End, dot + 1, packed);

                        Assert(intermediate.Start == packed.Start);
                        Assert(intermediate.End == packed.End);

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
                                    var list = new List<Cursor>();
                                    list.Add(start);
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

        private Node? BuildKeyword(Keyword matcher, Cursor start, Cursor end)
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
            var context = matcher.Context(start, end);

            Assert(context != null);

            if (context != null && context.Nexts.Contains(end))
            {
                return NewTerminal(matcher, start, context.Core, end);
            }

            return null;
        }

        private Node? BuildNonterminal(Role role, Rule matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start, end);

            Assert(context != null);

            if (context != null)
            {
                if (matcher is StartRule startRule)
                {
                    end = startRule.White!.Value;
                }
                var children = BuildMatcher(matcher, start, end).ToArray();

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

        private Nonterminal NewNonterminal(Role role, Matcher matcher, Cursor start, Cursor end, IEnumerable<Packed> nodes)
        {
            return NewNonterminal(role, matcher, start, end, nodes.ToArray());
        }

        private Nonterminal NewNonterminal(Role role, Matcher matcher, Cursor start, Cursor end, params Packed[] nodes)
        {
            nodes = ReduceEmptyTails(nodes).ToArray();

            switch (role)
            {
                case Role.Optional:
                case Role.Star:
                    Assert(nodes.Length >= 0);
                    break;
                default:
                    Assert(nodes.Length >= 1);
                    break;
            }

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
            if (nodes.Length >= 2)
            {
                Assert(true);
            }
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

        /********** policies */

        private IEnumerable<Node> ReduceAlternates(IEnumerable<Node> packeds)
        {
            //
            // strange policy:
            //   select first alternate
            //
            return Enumerable.Repeat(packeds.First(), 1);
        }

        private IEnumerable<Packed> ReduceEmptyTails(Packed[] packeds)
        {
            //
            // strange policy:
            //   remove empty tails
            //
            if (packeds.Length >= 2)
            {
                Assert(true);
                foreach (var packed in packeds)
                {
                    if (packed.Pivot < packed.End)
                    {
                        yield return packed;
                    }
                }
            }
            else
            {
                foreach (var packed in packeds)
                {
                    yield return packed;
                }
            }
        }
    }
}
