namespace Six.Runtime.Types
{
    public class ROptional : RNode
    {
        public ROptional(params RNode[] children)
            : base(children)
        {
        }
    }

    public class ROptional<T> : ROptional
        where T : class
    {
        public ROptional(params RNode[] children)
            : base(children)
        {
        }
    }
}
