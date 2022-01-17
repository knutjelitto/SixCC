using Six.Runtime.Sppf;

namespace Six.Runtime.Types
{
    public class TypedBuilder
    {
        public TypedBuilder(Symbol root)
        {
            Root = root;
        }

        public Symbol Root { get; }

        public RNode Build()
        {
            return Build(Root).Single();
        }

        private IEnumerable<RNode> Build(Node anyNode)
        {
            switch (anyNode)
            {
                case Nonterminal node:
                    return BuildNonterminal(node);
                case Packed node:
                    return BuildPacked(node);
                case Intermediate node:
                    return BuildIntermediate(node);
                case Terminal node:
                    return BuildTerminal(node);
                default:
                    throw new NotImplementedException($"can't build tree for node of type '{anyNode.GetType().Name}'");
            }
        }

        private IEnumerable<RNode> BuildNonterminal(Nonterminal node)
        {
            if (node.Matcher.Creator != null)
            {
                if (node.Children.Length == 1 && node.Children[0] is Terminal)
                {
                    yield return node.Matcher.Creator.Invoke(node.Children[0]);

                    yield break;
                }
            }

            Assert(node.Matcher.Builder != null);

            if (node.Children.Length == 0)
            {
                if (node.Matcher.Builder != null)
                {
                    yield return node.Matcher.Builder!.Invoke();
                }
                else
                {
                    yield return new RNode();
                }
            }
            else
            {
                var args = Build(node.Children[0]).ToArray();

                if (node.Matcher.Builder != null)
                {
                    var build = node.Matcher.Builder!.Invoke(args);
                    yield return build;
                }
                else
                {
                    Assert(args.Length == 1);
                    yield return new RNode(args);
                }
            }
        }

        private IEnumerable<RNode> BuildPacked(Packed node)
        {
            if (node.Left == null)
            {
                return Build(node.Right);
            }
            else
            {
                return Build(node.Left).Concat(Build(node.Right));
            }
        }

        private IEnumerable<RNode> BuildIntermediate(Intermediate node)
        {
            return Build(node.Children[0]);
        }

        private static IEnumerable<RNode> BuildTerminal(Terminal node)
        {
            Assert(node.Matcher.Creator != null);

            if (node.Matcher.Creator != null)
            {
                yield return node.Matcher.Creator!.Invoke(node);
            }
        }
    }
}
