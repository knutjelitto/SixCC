using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public abstract class Node
    {
        public Node(Matcher matcher, Cursor start, Cursor end)
        {
            Matcher = matcher;
            Start = start;
            End = end;
        }

        protected string Extend()
        {
            return Extend(Matcher, Start, End, null);
        }

        protected static string Extend(Matcher matcher, Cursor start, Cursor end, Cursor? pivot)
        {
            if (pivot is null)
            {
                return $"[{start.Offset}-{end.Offset}] {matcher.Name}";
            }
            else
            {
                return $"[{start.Offset}-{pivot.Value.Offset}-{end.Offset}] {matcher.Name}";
            }
        }

        public string Name => Matcher.Name;

        public Matcher Matcher { get; }
        public Cursor Start { get; }
        public Cursor End { get; }

        public bool IsDrop => Matcher is Drop;
        public bool IsLift => Matcher is Lift;
    }
}
