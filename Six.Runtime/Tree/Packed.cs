using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public sealed record Packed(Cursor Start, Cursor End, Matcher Matcher, Cursor Pivot, Node? Left, Node Right)
        : Node(Start, End, Matcher)
    {
        public override string ToString()
        {
            return $"<packed> {Extend()} ({Pivot.Offset})";
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher, Cursor pivot)
        {
            return $"<packed> {Extend(start, end, matcher)} ({pivot.Offset})";
        }
    }
}
