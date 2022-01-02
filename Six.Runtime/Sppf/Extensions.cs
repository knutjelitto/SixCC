using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static bool CanMatch(this Matcher matcher, Cursor start, Cursor end)
        {
            return matcher.Context(start).Nexts.Contains(end);
        }

        public static IEnumerable<T> Realize<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.ToList();
        }
    }
}
