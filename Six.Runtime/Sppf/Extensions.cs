using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public static class Extensions
    {
        public static bool CanMatch(this Matcher matcher, Cursor start, Cursor end)
        {
            return matcher.CanMatch(start, end);
        }
    }
}
