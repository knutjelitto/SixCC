using Six.Six.Instructions;
using Six.Six.Types;
using System;

namespace Six.Six.Sema
{
    public sealed class LazyExpr : Lazy<Expr>, Entity
    {
        public LazyExpr(Func<Expr> resolver)
            : base(resolver)
        {
        }
    }
}
