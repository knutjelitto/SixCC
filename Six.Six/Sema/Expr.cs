using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Expr : Entity
    {
        Type? Type { get; }

        public sealed record Delayed : Expr
        {
            public Expr? Resolved { get; set; } = null;
            public Type? Type => Resolved?.Type;

            public bool Ok => Resolved != null;
        }

        public sealed record Natural(Type Type, ulong value) : Expr;

        public sealed record Reference(Decl Decl) : Expr
        {
            public Type? Type => Decl.Type;
        }

        public sealed record ParameterReference(Decl Decl) : Expr
        {
            public Type? Type => Decl.Type;
        }

        public sealed record CallMember(Expr Make, Type.Callable Callable, params Expr[] Arguments) : Expr
        {
            public Type? Type => Callable.Result;
        }
    }
}
