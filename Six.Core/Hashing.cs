namespace Six.Core
{
    public static class Hashing
    {
        public static int Hash<T>(this IEnumerable<T> values)
        {
#if true
            var hash = 0;

            foreach (var value in values)
            {
                hash = (hash << 1) + (value?.GetHashCode() ?? -1);
            }

            return hash;
#else
            var hash = new HashCode();

            foreach (var value in values)
            {
                hash.Add(value);
            }

            return hash.ToHashCode();
#endif
        }
    }
}
