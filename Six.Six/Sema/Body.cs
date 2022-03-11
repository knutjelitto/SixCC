using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Body
    {
        public record Value(Func<Expr.Concrete> Resolver) : Body
        {
            private Expr.Concrete? concrete;
            public Expr.Concrete Expr => concrete ??= Resolver();
        }

        public record Dummy() : Body
        {
        }
    }
}
