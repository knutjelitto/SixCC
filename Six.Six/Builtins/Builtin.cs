using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Builtins
{
    public abstract class Builtin : Type.Builtin
    {
        protected readonly Dictionary<string, Func<Expr, Expression.Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr, Expr, Expression.Primitive>> infix = new();

        protected Builtin(Builtins builtins, string name)
        {
            Builtins = builtins;
            Name = name;
        }

        public abstract string AsWasm { get; }
        public Builtins Builtins { get; }
        public string Name { get; }
        public Resolver Resolver => Builtins.Resolver;

        public Type LowerType(Type type) => Resolver.LowerType(type);

        public bool IsThis(Expr expr) => ReferenceEquals(LowerType(expr.Type), this);

        public Func<Expr, Expression.Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public Func<Expr, Expr, Expression.Primitive> Infix(string name)
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
