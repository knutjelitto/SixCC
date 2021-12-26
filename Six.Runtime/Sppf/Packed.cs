using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public sealed class Packed: Node
    {
        public Packed(Matcher matcher, Cursor start, Cursor end, Cursor pivot, Node? left, Node right)
            : base(matcher, start, end)
        {
            Pivot = pivot;
            Left = left;
            Right = right;
        }
        public Cursor Pivot { get; }
        public Node? Left { get; }
        public Node Right { get; }

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
