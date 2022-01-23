using System.Runtime.CompilerServices;

namespace Six.Core
{
    public class IdentityEquality<TKey> : IEqualityComparer<TKey>
        where TKey : class
    {
        public bool Equals(TKey x, TKey y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(TKey obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }
}
