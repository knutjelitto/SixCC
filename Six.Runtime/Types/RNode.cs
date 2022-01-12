namespace Six.Runtime.Types
{
    public class RNode
    {
        public RNode(params RNode[] children)
        {
            Children = children;
        }

        public RNode[] Children { get; }
    }
}
