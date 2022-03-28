﻿using Six.Core;
using Six.Runtime;
using Six.Six.Builtins;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public BuiltinCore Lower(Type type)
        {
            var lower = Resolver.LowerType(type);

            switch (lower)
            {
                case BuiltinCore builtin:
                    return builtin;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private string Params(IEnumerable<Decl.Local> locals)
        {
            var builder = new StringBuilder();

            builder.Append("(param");
            foreach (var local in locals)
            {
                builder.Append($" (;{local.Index}/{local.Name}:{Resolver.ResolveType(local.Type)};) {WasmTypeFor(local.Type)}");
            }
            builder.Append(")");

            return builder.ToString();
        }

        private string Local(Decl.Local decl)
        {
            return $"(local (;{decl.Index}/{decl.Name};) {WasmTypeFor(decl.Type)})";
        }

        private string? ExportIff(Decl decl)
        {
            if (decl.IsShared)
            {
                return $" (export \"{decl.FullName}\")";
            }
            return null;
        }

        private string Export(Decl decl)
        {
            return $"(export \"{decl.FullName}\")";
        }

        private string IdFor(Decl decl)
        {
            return $" ${decl.FullName}";
        }

        private string TypeFor(Decl.Global global)
        {
            var lower = Lower(global.Type);

            if (global.Writeable)
            {
                return $" (mut {lower.Wasm.Type})";
            }
            return $" {lower.Wasm.Type}";
        }

        public BuiltinCore BuiltinFor(Type type)
        {
            switch (Resolver.LowerType(type))
            {
                case BuiltinCore builtin:
                    return builtin;
                case Type.Callable:
                    return Builtins.TableIndex;
                case Type.Declared declared when declared.Decl.IsNative:
                    return Builtins.Resolve(declared.Decl);
                case Type.Declared declared when declared.Decl is Decl.Classy:
                    return Builtins.Pointer;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        public string WasmTypeFor(Type type)
        {
            return BuiltinFor(type).Wasm.Type;
        }

        private string? Result(Type type)
        {
            Assert(type != null);
            if (type is Type.Declared)
            {
                Assert(true);
            }
            switch (type)
            {
                case Type.Declared declared when declared.Decl.FullName == Names.Core.CoreAnything:
                    return null;
                case BuiltinCore builtin when builtin.Name == Names.Core.Anything:
                    return null;
                default:
                    return $"(result {WasmTypeFor(type)})";
            }
        }

        public string TypeFor(Type.Callable type)
        {
            return $"(type {Types.FindType(type)})";
        }

        public bool IsAnythingAkaVoid(Type type)
        {
            return Resolver.ResolveType(type) is Type.ClassyReference reference && reference.Decl.FullName == Names.Core.CoreAnything;
        }

        private void Horizontal(IEnumerable<Action> actions)
        {
            var more = false;
            foreach (var action in actions)
            {
                if (more)
                {
                    w(" ");
                }
                action();
                more = true;
            }
            if (more)
            {
                wl();
            }
        }

        private void Vertical(IEnumerable<Action> actions)
        {
            foreach (var action in actions)
            {
                action();
            }
        }

        private void VerticalSpaced(IEnumerable<Action> actions)
        {
            var more = false;
            foreach (var action in actions)
            {
                if (more)
                {
                    wl();
                }
                action();
                more = true;
            }
        }
    }
}
