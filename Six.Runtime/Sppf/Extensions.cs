using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public static class Extensions
    {
        public static IEnumerable<T> Realize<T>(this IEnumerable<T> enumerable)
        {
            return enumerable;
        }
    }
}
