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

        public static TreeNode Build(Symbol root)
        {
            return new TreeBuilder(root).Work();
        }

        public TreeNode Work()
        {
            return Work(Root).Single();
        }

        private IEnumerable<TreeNode> Work(Node anyNode)
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
                case Terminal node:
                    return BuildTerminal(node);
                case Packed node:
                    return BuildPacked(node);
                case Intermediate node:
                    return BuildIntermediate(node);
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
                yield return new TreeNode(node, Work(node.Children[0]).ToArray());
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
                return Work(node.Children[0]);
            }
        }

        private IEnumerable<TreeNode> BuildPacked(Packed node)
        {
            if (node.Left == null)
            {
                return Work(node.Right);
            }
            else
            {
                return Work(node.Left).Concat(Work(node.Right));
            }
        }

        private IEnumerable<TreeNode> BuildIntermediate(Intermediate node)
        {
            return Work(node.Children[0]);
        }

        private static IEnumerable<TreeNode> BuildTerminal(Terminal node)
        {
            yield return new TerminalNode(node);
        }
    }
}
