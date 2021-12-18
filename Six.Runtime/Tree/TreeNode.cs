using Six.Runtime.Matchers;
using Six.Runtime.Sppf;

namespace Six.Runtime.Tree
{
    public class TreeNode
    {
        public TreeNode(Terminal node, params TreeNode[] children)
        {
            Node = node;
            Children = children;
            Name = node.Name;
        }

        public TreeNode(Nonterminal node, params TreeNode[] children)
        {
            Node = node;
            Children = children;
            Name = node.Name;

            switch (node.Role)
            {
                case Role.Star:
                    Name = "*";
                    break;
                case Role.Plus:
                    Name = "+";
                    break;
                case Role.Optional:
                    Name = "?";
                    break;
            }
        }

        public Node Node { get; }
        public TreeNode[] Children { get; }
        public Matcher Matcher => Node.Matcher;
        public string Name { get; }
        public Cursor Start => Node.Start;
        public Cursor End => Node.End;

        public override string ToString()
        {
            return Name;
        }
    }
}
