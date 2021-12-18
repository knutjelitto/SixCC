using Six.Runtime.Sppf;

namespace Six.Runtime.Tree
{
    public class TreeBuilder
    {
        public TreeBuilder(Symbol root)
        {
            Root = root;
        }

        public Symbol Root { get; }

        public TreeNode Build()
        {
            return Build(Root).Single();
        }

        private IEnumerable<TreeNode> Build(Node anyNode)
        {
            switch (anyNode)
            {
                case Nonterminal node when node.Role == Role.Start:
                    return BuildStructural(node);
                case Nonterminal node when node.Role == Role.Rule:
                    return BuildStructural(node);
                case Nonterminal node when node.Role == Role.Plus:
                    return BuildStructural(node);
                case Nonterminal node when node.Role == Role.Star:
                    return BuildStructural(node);
                case Nonterminal node when node.Role == Role.Optional:
                    return BuildStructural(node);

                case Nonterminal node when node.Role == Role.Seq:
                    return BuildSeq(node);
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

        private IEnumerable<TreeNode> BuildStructural(Nonterminal node)
        {
            if (node.Children.Length == 0)
            {
                yield return new TreeNode(node);
            }
            else
            {
                yield return new TreeNode(node, Build(node.Children[0]).ToArray());
            }
        }

        private IEnumerable<TreeNode> BuildSeq(Nonterminal node)
        {
            Assert(node.Role == Role.Seq);

            if (node.Children.Length == 0)
            {
                return Enumerable.Empty<TreeNode>();
            }
            else
            {
                return Build(node.Children[0]);
            }
        }

        private IEnumerable<TreeNode> BuildPacked(Packed node)
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

        private IEnumerable<TreeNode> BuildIntermediate(Intermediate node)
        {
            return Build(node.Children[0]);
        }

        private IEnumerable<TreeNode> BuildTerminal(Terminal node)
        {
            yield return new TerminalNode(node);
        }
    }
}
