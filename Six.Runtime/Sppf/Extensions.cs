using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static bool CanMatch(this Matcher matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            return context != null && context.Nexts.Contains(end);
        }

        public static Context? Context(this Matcher matcher, Cursor start, Cursor end)
        {
            var context = matcher.Context(start);

            return (context != null && context.Nexts.Contains(end)) ? context : null;
        }
    }
}
