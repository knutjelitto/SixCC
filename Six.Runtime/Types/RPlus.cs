namespace Six.Runtime.Types
{
    public class RPlus : RNode
    {
        public RPlus(params RNode[] children)
            : base(children)
        {
            Assert(Children.Length > 0);
        }
    }

    public class RPlus<T> : RPlus
        where T : class
    {
        public RPlus(params RNode[] children)
            : base(children)
        {
        }
    }
}
