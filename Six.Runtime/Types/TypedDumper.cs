using Six.Core;

namespace Six.Runtime.Types
{
    public class TypedDumper : WithWriter
    {
        public TypedDumper(RNode root, Writer writer)
            : base(writer)
        {
            Root = root;
        }

        public RNode Root { get; }

        public static void Dump(RNode root, Writer writer)
        {
            new TypedDumper(root, writer).Dump();
        }

        public void Dump()
        {
            Dump(Root);
        }

        private void Dump(RNode node)
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
