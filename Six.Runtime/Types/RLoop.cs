namespace Six.Runtime.Types
{
    public class RLoop<T> : RNode
        where T : class
    {
        public RLoop(params RNode[] children)
            : base(children)
        {
        }
    }
}
