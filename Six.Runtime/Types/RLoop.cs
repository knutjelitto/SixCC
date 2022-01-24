namespace Six.Runtime.Types
{
    public class RLoop<T> : RNode
        where T : class
    {
        public RLoop(params RNode[] children)
            : base(MakeElements(children))
        {
            Assert(children.Length == 2);
            Elements = Children.Cast<T>().ToArray();
            Separators = MakeSeparators(children);

            Assert(Separators.Length + 1 == Children.Length);
        }

        public T[] Elements { get; }
        public RNode[] Separators { get; }

        private static RNode[] MakeElements(RNode[] children)
        {
            return Enumerable.Repeat(children[0], 1).Concat(elements(children[1])).ToArray();

            static IEnumerable<RNode> elements(RNode seconds)
            {
                foreach (var child in seconds.Children)
                {
                    Assert(child.Children.Length == 2);

                    yield return child.Children[1];
                }
            }
        }

        private static RNode[] MakeSeparators(RNode[] children)
        {
            return separators(children[1]).ToArray();

            static IEnumerable<RNode> separators(RNode seconds)
            {
                foreach (var child in seconds.Children)
                {
                    Assert(child.Children.Length == 2);

                    yield return child.Children[0];
                }
            }
        }
    }
}
