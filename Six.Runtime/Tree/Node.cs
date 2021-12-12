using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public abstract record Node(Cursor Start, Cursor End, Matcher Matcher)
    {
        protected string Extend()
        {
            return Extend(Start, null, End, Matcher);
        }

        protected static string Extend(Cursor start, Cursor? pivot, Cursor end, Matcher matcher)
        {
            if (pivot is null)
            {
                return $"{matcher.Name} [{start.Offset}-{end.Offset}]";
            }
            else
            {
                return $"{matcher.Name} [{start.Offset}-{pivot.Value.Offset}-{end.Offset}]";
            }
        }

        public string Name => Matcher.Name;
    }
}
