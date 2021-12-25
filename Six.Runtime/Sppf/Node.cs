using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public abstract record Node(Matcher Matcher, Cursor Start, Cursor End)
    {
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

        public Cursor Core => Matcher.Contexts[Start].Core;

        public string Name => Matcher.Name;
    }
}
