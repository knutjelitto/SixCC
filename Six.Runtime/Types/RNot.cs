namespace Six.Runtime.Types
{
    public class RNot<T> : RNode
        where T : class
    {
        public RNot(params RNode[] children)
            : base(children)
        {
        }
    }
}
