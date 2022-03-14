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
        private string FindType(Type.Callable callable)
        {
            var funcType = FuncType(callable);

            if (!functionTypes.TryGetValue(funcType, out var index))
            {
                index = (uint)functionTypes.Count;

                functionTypes.Add(funcType, index);
            }

            return $"$funcType{index}";
        }

        private string FuncType(Type.Callable callable)
        {
            return $"(func {Signature(callable)})";
        }

        private string Signature(Type.Callable callable)
        {
            var builder = new StringBuilder();
            builder.Append("(param");
            foreach (var param in callable.Parameters)
            {
                builder.Append($" {WasmTypeFor(param)}");
            }
            builder.Append($") (result");
            if (!IsAnythingAkaVoid(callable.Result))
            {
                builder.Append($" {WasmTypeFor(callable.Result)}");
            }
            builder.Append(')');

            return builder.ToString();
        }

        private string Param(Decl.Local decl)
        {
            return $"(param (;{decl.Index}/{decl.Name};) {WasmTypeFor(decl.Type)})";
        }

        private string Local(Decl.Local decl)
        {
            return $"(local (;{decl.Index}/{decl.Name};) {WasmTypeFor(decl.Type)})";
        }

        private string WasmTypeFor(Type type)
        {
            switch (type)
            {
                case Builtin builtin:
                    return $"{builtin.AsWasm}";
                case Type.Callable:
                    return $"{Builtins.TableIndex.AsWasm}";
                case Type.Declared declared when declared.Decl.IsNative():
                    {
                        var builtin = Builtins.Resolve(declared.Decl);
                        return $"{builtin.AsWasm}";
                    }
                default:
                    Assert(false);
                    return $"(;wasm-type:?????;)";
            }
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
                case Type.Declared declared when declared.Decl.Name.Text == Names.Core.Anything:
                    return null;
                case Builtin builtin when builtin.Name == Names.Core.Anything:
                    return null;
                default:
                    return $"(result {WasmTypeFor(type)})";
            }
        }

        private bool IsAnythingAkaVoid(Type type)
        {
            return Resolver.ResolveType(type) is Type.Reference reference && reference.Decl.Name.Text == Names.Core.Anything;
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
