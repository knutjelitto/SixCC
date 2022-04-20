using System;
using System.Collections;

namespace Six.Six.Sema
{
    public sealed class LazyType : Lazy<Type>, Entity
    {
        public LazyType(Func<Type> resolver)
            : base(resolver)
        {
        }
    }
}
