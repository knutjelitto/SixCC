using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class Builtin
    {
        private static readonly Dictionary<string, Builtin> buildins = new();
        protected readonly Dictionary<string, Func<Expr.Concrete, Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr.Concrete, Expr.Concrete, Primitive>> infix = new();

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

        public Func<Expr.Concrete, Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new NotImplementedException();
        }

        public Func<Expr.Concrete, Expr.Concrete, Primitive> Infix(string name)
        {
            if (infix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new NotImplementedException();
        }
    }
}
