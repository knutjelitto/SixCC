namespace Six.Runtime.Types
{
    public class ROptional<T> : RNode
        where T : class
    {
        public ROptional(params RNode[] children)
            : base(children)
        {
        }
    }
}
