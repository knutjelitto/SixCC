using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Builtins
{
    public abstract class Builtin : Type.Builtin
    {
        protected readonly Dictionary<string, Func<Expr.Concrete, Expr.Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr.Concrete, Expr.Concrete, Expr.Primitive>> infix = new();

        public abstract string AsWasm { get; }

        public Func<Expr.Concrete, Expr.Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public Func<Expr.Concrete, Expr.Concrete, Expr.Primitive> Infix(string name)
        {
            if (infix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public override string ToString()
        {
            return $"<{GetType().Name.ToLowerInvariant()}>";
        }
    }
}
