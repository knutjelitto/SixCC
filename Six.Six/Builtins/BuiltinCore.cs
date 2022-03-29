﻿using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Builtins
{
    public abstract class BuiltinCore : Type.Builtin
    {
        protected readonly Dictionary<string, Func<Expr, Expr.Primitive>> prefix = new();
        protected readonly Dictionary<string, Func<Expr, Expr, Expr.Primitive>> infix = new();
        protected readonly List<Dictionary<string, Func<List<Expr>, Expr.Primitive>>> methods = new();

        protected BuiltinCore(Builtins builtins, string name, WasmDef wasm)
        {
            Builtins = builtins;
            Wasm = wasm;
            Name = name;
        }

        public Builtins Builtins { get; }
        public WasmDef Wasm { get; }
        public string Name { get; }

        public Module Module => Builtins.Module;
        public Resolver Resolver => Module.Resolver;
        public TypeChecker Checker => Module.Checker;
        
        public bool IsThis(Expr expr) => Checker.CanAssign(this, Resolver.LowerType(expr.Type));

        public abstract Insn Load(uint offset);
        public abstract Insn Store(uint offset);

        public void AddMethod(string name, int arity, Func<List<Expr>, Expr.Primitive> build)
        {
            while (methods.Count <= arity)
            {
                methods.Add(new Dictionary<string, Func<List<Expr>, Expr.Primitive>>());
            }
            methods[arity].Add(name, build);
        }

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

        public Func<List<Expr>, Expr.Primitive> Method(string name, int arity)
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
