using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public sealed record Packed(Matcher Matcher, Cursor Start, Cursor End, Cursor Pivot, Node? Left, Node Right)
        : Node(Matcher, Start, End)
    {
        public override string ToString()
        {
            return Key(Matcher, Start, End, Pivot);
        }

        public static string Key(Matcher matcher, Cursor start, Cursor end, Cursor pivot)
        {
            return $"<packed> {Extend(matcher, start, end, pivot)}";
        }
    }
}
