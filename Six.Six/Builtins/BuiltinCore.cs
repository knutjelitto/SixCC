using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Builtins
{
    public abstract class BuiltinCore : Type.Builtin
    {
        protected readonly Dictionary<string, Func<Expr, Expr.Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr, Expr, Expr.Primitive>> infix = new();

        protected BuiltinCore(Builtins builtins, string name, WasmDef wasm)
        {
            Builtins = builtins;
            Wasm = wasm;
            Name = name;
        }

        public Builtins Builtins { get; }
        public WasmDef Wasm { get; }
        public string Name { get; }
        public Resolver Resolver => Builtins.Resolver;
        
        public bool IsThis(Expr expr) => ReferenceEquals(Resolver.LowerType(expr.Type), this);

        public abstract Insn Load(uint offset);
        public abstract Insn Store(uint offset);

        public Func<Expr, Expr.Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public Func<Expr, Expr, Expr.Primitive> Infix(string name)
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
