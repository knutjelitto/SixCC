using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Body
    {
        public record Value(Func<Expr> Resolver) : Body
        {
            private Expr? concrete;
            public Expr Expr => concrete ??= Resolver();
        }

        public record Dummy() : Body
        {
        }
    }
}
