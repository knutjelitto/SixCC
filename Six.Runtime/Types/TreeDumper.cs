using Six.Core;

namespace Six.Runtime.Types
{
    public class TypedDumper : IWithWriter
    {
        public TypedDumper(RNode root, Writer writer)
        {
            Root = root;
            Writer = writer;
        }

        public RNode Root { get; }
        public Writer Writer { get; }

        protected IWithWriter w => this;

        public void Dump()
        {
            Dump(Root);
        }

        private void Dump(RNode node)
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
