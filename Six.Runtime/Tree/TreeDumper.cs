using Six.Core;

namespace Six.Runtime.Tree
{
    public class TreeDumper : IWithWriter
    {
        public TreeDumper(TreeNode root, Writer writer)
        {
            Root = root;
            Writer = writer;
        }

        public TreeNode Root { get; }
        public Writer Writer { get; }

        protected IWithWriter w => this;

        public void Dump()
        {
            Dump(Root);
        }

        private void Dump(TreeNode node)
        {
            w.wl($"{node}");
            w.indent(() =>
            {
                foreach (var child in node.Children)
                {
                    Dump(child);
                }
            });
        }
    }
}
