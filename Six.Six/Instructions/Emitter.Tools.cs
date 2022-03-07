using Six.Core;
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

        private string Param(Decl.Parameter decl)
        {
            switch (decl.Type!)
            {
                case Builtin builtin:
                    return $"(param (;{decl.Index}/{decl.Name};) {builtin.AsWasm})";
                default:
                    Assert(false);
                    return $"(param <!<{decl.FullName}>!>)";
            }
        }

        private string Local(Decl.Local decl)
        {
            return $"(local (;{decl.Index}/{decl.Name};) {WasmTypeFor(decl.Type!)})";
        }

        private string WasmTypeFor(Type type)
        {
            switch (type)
            {
                case Builtin builtin:
                    return $"{builtin.AsWasm}";
                case Type.Callable:
                    return $"{Builtins.TableIndex.AsWasm}";
                default:
                    Assert(false);
                    return $"(;wasm-type:?????;)";
            }
        }

        private string? Result(Type type)
        {
            Assert(type != null);
            switch (type)
            {
                case Builtin builtin:
                    return $"(result {builtin.AsWasm})";
                default:
                    if (IsAnythingAkaVoid(type))
                    {
                        return null;
                    }
                    Assert(false);
                    return $"(result <!<?????>!>)";
            }
        }

        private bool IsAnythingAkaVoid(Type type)
        {
            return Resolver.ResolveType(type) is Type.Reference reference && reference.Decl.Name.Text == Module.Core.Anything;
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
