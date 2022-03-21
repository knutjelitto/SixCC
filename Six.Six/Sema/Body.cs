using System;

namespace Six.Six.Sema
{
    public interface Body
    {
        public record Expression(Func<Expr> Resolver) : Body
        {
            private Expr? concrete;
            public Expr Expr => concrete ??= Resolver();
        }

        public record Dummy() : Body
        {
        }
    }
}
