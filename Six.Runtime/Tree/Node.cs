using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public abstract record Node(Cursor Start, Cursor End, Matcher Matcher)
    {
        protected string Extend()
        {
            return Extend(Start, End, Matcher);
        }

        protected static string Extend(Cursor start, Cursor end, Matcher matcher)
        {
            return $"{matcher.Name} [{start.Offset}-{end.Offset}]";
        }

        public string Name => Matcher.Name;
    }
}
