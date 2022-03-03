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
            switch (decl.Type!)
            {
                case Builtin builtin:
                    return $"(local (;{decl.Index}/{decl.Name};) {builtin.AsWasm})";
                default:
                    Assert(false);
                    return $"(local <!<{decl.FullName}>!>)";
            }
        }

        private string? Result(Type type)
        {
            switch (type)
            {
                case Builtin builtin:
                    return $"(result {builtin.AsWasm})";
                default:
                    var resolved = Resolver.ResolveType(type);
                    if (resolved is Type.Reference reference && reference.Decl.Name.Text == Module.Core.Anything)
                    {
                        return null;
                    }
                    Assert(false);
                    return $"(result <!<?????>!>)";
            }
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
