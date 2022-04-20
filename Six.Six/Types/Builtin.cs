using System;

using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Types
{
    public abstract class Builtin : Type.Builtin
    {
        protected readonly List<Dictionary<string, Func<List<Expr>, Primitive>>> methods = new();

        protected Builtin(Builtins builtins, string name, WasmType wasm)
        {
            Builtins = builtins;
            Name = name;
            Wasm = wasm;
        }

        protected Builtin(Builtins builtins)
            : this(builtins, Names.Core.Builtin, WasmType.Addr)
        {
        }

        public Builtins Builtins { get; }
        public WasmType Wasm { get; }
        public string Name { get; }

        public Module Module => Builtins.Module;
        public Resolver Resolver => Module.Resolver;
        public TypeChecker Checker => Module.Checker;
        
        public bool IsThis(Expr expr) => Checker.CanAssign(this, Resolver.T.LowerType(expr.Type));

        public abstract Insn Load(uint offset);
        public abstract Insn Store(uint offset);

        public void AddPrefix(string name, Func<List<Expr>, Primitive> build)
        {
            AddMethod(name.PrefixName(), 1, build);
        }

        public void AddInfix(string name, Func<List<Expr>, Primitive> build)
        {
            AddMethod(name.InfixName(), 2, build);
        }

        public void AddMethod(string name, int arity, Func<List<Expr>, Primitive> build)
        {
            while (methods.Count <= arity)
            {
                methods.Add(new Dictionary<string, Func<List<Expr>, Primitive>>());
            }
            methods[arity].Add(name, build);
        }

        public Func<List<Expr>, Primitive> Method(string name, int arity)
        {
            if (methods.Count > arity && methods[arity].TryGetValue(name, out var action))
            {
                return action;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }

        protected Primitive Binop(Insn insn, List<Expr> args)
        {
            Assert(args.Count == 2);

            Assert(IsThis(args[0]));
            Assert(IsThis(args[1]));

            return new Primitive.Binop(this, insn, args[0], args[1]);
        }

        protected Primitive PredBinop(Insn insn, List<Expr> args)
        {
            Assert(args.Count == 2);

            Assert(IsThis(args[0]));
            Assert(IsThis(args[1]));

            return new Primitive.Binop(Builtins.Boolean, insn, args[0], args[1]);
        }

        public override string ToString()
        {
            return $"<{GetType().Name.ToLowerInvariant()}>";
        }
    }
}
