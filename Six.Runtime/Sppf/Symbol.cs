using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public abstract record Symbol(Matcher Matcher, Cursor Start, Cursor End, params Node[] Children)
        : Node(Matcher, Start, End)
    {
    }
}
