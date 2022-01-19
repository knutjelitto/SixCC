using Six.Core;

namespace Six.Runtime.Tree
{
    public class TreeDumper : WithWriter
    {
        public TreeDumper(TreeNode root, Writer writer)
            : base(writer)
        {
            Root = root;
        }

        public TreeNode Root { get; }

        public static void Dump(TreeNode root, Writer writer)
        {
            new TreeDumper(root, writer).Dump();
        }

        public void Dump()
        {
            Dump(Root);
        }

        private void Dump(TreeNode node)
        {
            wl($"{node}");
            indent(() =>
            {
                foreach (var child in node.Children)
                {
                    Dump(child);
                }
            });
        }
    }
}
