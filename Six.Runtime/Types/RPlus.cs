namespace Six.Runtime.Types
{
    public class RPlus<T> : RNode
        where T : class
    {
        public RPlus(params RNode[] children)
            : base(children)
        {
        }
    }
}
