using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Builtins
{
    public class Builtin : Type.Builtin
    {
        private static readonly Dictionary<string, Builtin> buildins = new();
        protected readonly Dictionary<string, Func<Expr.Concrete, Expr.Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr.Concrete, Expr.Concrete, Expr.Primitive>> infix = new();

        static Builtin()
        {
            buildins.Add(Module.Core.Int32, new I32());
        }

        public static Builtin Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new NotImplementedException();
        }

        public Func<Expr.Concrete, Expr.Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new NotImplementedException();
        }

        public Func<Expr.Concrete, Expr.Concrete, Expr.Primitive> Infix(string name)
        {
            if (infix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"<{GetType().Name.ToLowerInvariant()}>";
        }
    }
}
