using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public sealed record Packed(Cursor Start, Cursor End, Matcher Matcher, Cursor Pivot, Node? Left, Node Right)
        : Node(Start, End, Matcher)
    {
        public override string ToString()
        {
            return Key(Start, End, Matcher, Pivot);
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher, Cursor pivot)
        {
            return $"<packed> {Extend(start, pivot, end, matcher)}";
        }
    }
}
