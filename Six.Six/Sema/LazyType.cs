using System;
using System.Collections;

namespace Six.Six.Sema
{
    public sealed class LazyType : Entity
    {
        private Type? type = null;

        public LazyType(Func<Type> resolver)
        {
            Resolver = resolver;
        }

        public Func<Type> Resolver { get; }

        public Type Value => type ??= Resolver();
    }
}
