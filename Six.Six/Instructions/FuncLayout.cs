﻿using Six.Runtime;
using Six.Six.Types;
using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Instructions
{
    public class FuncLayout : WithWriter
    {
        public readonly List<Decl.Local> TypedParameters = new();
        public readonly List<Decl.Local> TypedLocals = new();
        private readonly List<LocalCore> parameters = new();
        private readonly List<LocalCore> locals = new();

        public FuncLayout(Decl.Funcy funcy)
            : base(funcy.Block.Module.Emitter.Writer)
        {
            Funcy = funcy;
        }

        public Decl.Funcy Funcy { get; }
        public Module Module => Funcy.Block.Module;
        public Resolver Resolver => Module.Resolver;
        public Emitter Emitter => Module.Emitter;
        public Types.Builtins Builtins => Module.Builtins;

        public int AddParameter(Decl.Local parameter)
        {
            Assert(locals.Count == 0);

            TypedParameters.Add(parameter);

            var index = parameters.Count;
            parameter.Index = index;

            parameters.Add(new DeclaredLocal(Module, index, parameter));

            return index;
        }

        public int AddLocal(Decl.Local local)
        {
            TypedLocals.Add(local);

            var index = parameters.Count + locals.Count;
            local.Index = index;

            locals.Add(new DeclaredLocal(Module, index, local));

            return index;
        }

        public int AddLocal(Decl.Classy classy)
        {
            var index = parameters.Count + locals.Count;

            locals.Add(new ScratchLocal(Module, index, classy));

            return index;
        }

        public void EmitDeclarations()
        {
            if (parameters.Count == 0)
            {
                //wl("(param)");
            }
            else
            {
                wl($"(param {string.Join(" ", parameters)})");
            }

            if (Funcy.ResultType is Type.Void)
            {
                //wl("(result)");
            }
            else
            {
                var result = Emitter.BuiltinFor(Funcy.ResultType);
                wl($"(result (; {Emitter.Resolver.ResolveType(Funcy.ResultType)} ;) {result.Wasm.Type})");
            }

            if (locals.Count == 0)
            {
                //wl("(local)");
            }
            else
            {
                wl($"(local {string.Join(" ", locals)})");
            }
        }

        private class LocalCore
        {
            protected LocalCore(int index)
            {
                Index = index;
            }

            public int Index { get; }
        }

        private class DeclaredLocal : LocalCore
        {
            public DeclaredLocal(Module module, int index, Decl.Local decl)
                : base(index)
            {
                Module = module;
                Decl = decl;
            }

            public Decl.Local Decl { get; }
            public Module Module { get; }

            public override string ToString()
            {
                var name = Decl.Name;
                var resolved = Module.Resolver.ResolveType(Decl.Type);
                var builtin = Module.Emitter.BuiltinFor(Decl.Type);
                return $"(;{Index}/{name}:{resolved};) {builtin.Wasm.Type}";
            }
        }

        private class ScratchLocal : LocalCore
        {
            public ScratchLocal(Module module, int index, Decl.Classy decl)
                : base(index)
            {
                Module = module;
                Decl = decl;
            }

            public Decl.Classy Decl { get; }
            public Module Module { get; }

            public override string ToString()
            {
                var name = Decl.Name;
                var resolved = Module.Resolver.ResolveType(Decl.Type);
                var builtin = Module.Emitter.BuiltinFor(Decl.Type);
                return $"(;{Index}/<scratch>:{resolved};) {builtin.Wasm.Type}";
            }
        }
    }
}
