using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;
using System;
using Type = Six.Six.Sema.Type;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Builtin : Type.Builtin
    {
        protected readonly Dictionary<string, Func<Expr, Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr, Expr, Primitive>> infix = new();
        protected readonly List<Dictionary<string, Func<List<Expr>, Primitive>>> methods = new();

        protected Builtin(Builtins builtins, string name, W.WasmType wasm)
        {
            Builtins = builtins;
            Name = name;
            Wasm = wasm;
        }

        protected Builtin(Builtins builtins)
            : this(builtins, Names.Core.Builtin, WasmType.Ptr)
        {
        }

        public Builtins Builtins { get; }
        public W.WasmType Wasm { get; }
        public string Name { get; }

        public Module Module => Builtins.Module;
        public Resolver Resolver => Module.Resolver;
        public TypeChecker Checker => Module.Checker;
        
        public bool IsThis(Expr expr) => Checker.CanAssign(this, Resolver.LowerType(expr.Type));

        public abstract Insn Load(uint offset);
        public abstract Insn Store(uint offset);

        public void AddMethod(string name, int arity, Func<List<Expr>, Primitive> build)
        {
            while (methods.Count <= arity)
            {
                methods.Add(new Dictionary<string, Func<List<Expr>, Primitive>>());
            }
            methods[arity].Add(name, build);
        }

        public Func<Expr, Primitive> Prefix(string name)
        {
            if (prefix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public Func<Expr, Expr, Primitive> Infix(string name)
        {
            if (infix.TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        public Func<List<Expr>, Primitive> Method(string name, int arity)
        {
            if (methods.Count > arity && methods[arity].TryGetValue(name, out var action))
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
