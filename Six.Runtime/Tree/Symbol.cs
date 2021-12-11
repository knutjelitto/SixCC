using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public abstract record Symbol(Cursor Start, Cursor End, Matcher Matcher)
        : Node(Start, End, Matcher)
    {
    }
}
