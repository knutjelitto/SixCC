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
