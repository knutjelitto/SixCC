using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public abstract class Symbol : Node
    {
        public Symbol(Matcher matcher, Cursor start, Cursor end, params Node[] children)
            : base(matcher, start, end)
        {
            Children = children;
        }

        public Node[] Children { get; }
    }
}
