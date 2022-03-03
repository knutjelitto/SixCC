using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public partial class Emitter : WithWriter
    {
        private readonly List<string> exports = new();
        private readonly List<Action> functions = new();

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
        }

        private Module Module { get; }
        private Resolver Resolver => Module.Resolver;

        public void Emit(Entity entity)
        {
            Handle((dynamic)entity);
        }

        public void Emit()
        {
            wl($"(module");
            foreach (var ns in Module.GetNamespaces())
            {
                foreach (var decl in ns.GetDeclarations())
                {
                    if (decl is Decl.Function)
                    {
                        indent(() =>
                        {
                            Emit(decl);
                        });
                    }
                }
            }
            indent(() =>
            {
                foreach (var export in exports)
                {
                    wl(export);
                }
                wl();
                var more = false;
                foreach (var function in functions)
                {
                    if (more)
                    {
                        wl();
                    }
                    function();
                    more = true;
                }
            });
            wl($")");
        }

        private void Handle(Entity entity)
        {
            Assert(false);
        }

        private void Handle(Decl.Classy decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Alias decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Function decl)
        {
            exports.Add($"(export \"{decl.Container.FullName}\" (func ${decl.Container.FullName}))");

            functions.Add(() =>
            {
                wl($"(func ${decl.Container.FullName}");
                indent(() =>
                {
                    var more = false;
                    foreach (var param in decl.Parameters)
                    {
                        if (more)
                        {
                            w(" ");
                        }
                        w($"{Param(param)}");
                        more = true;
                    }
                    if (more)
                    {
                        wl();
                    }

                    wlif(Result(decl.Result!));

                    more = false;
                    foreach (var local in decl.Locals)
                    {
                        if (more)
                        {
                            w(" ");
                        }
                        w($"{Local(local)}");
                        more = true;
                    }
                    if (more)
                    {
                        wl();
                    }

                    wl("(;=====;)");
                    foreach (var member in decl.Members)
                    {
                        Emit(member);
                    }
                    wl("(;=====;)");
                });
                wl($")");

            });
        }

        private void Handle(Decl.Let decl)
        {
            if (decl.Value != null)
            {
                Emit(decl.Value);
                wl($"{Insn.Local.Set(decl.Index)}");
            }
            else
            {
                Assert(false);
            }
        }

        private void Handle(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Emit(stmt.Expr);
            }
            wl($"{Insn.Return}");
        }

        private void Handle(Expr.Binop expr)
        {
            Emit(expr.Arg1);
            Emit(expr.Arg2);
            wl($"{expr.Insn}");
        }

        private void Handle(Expr.Const expr)
        {
            wl($"{expr.Insn}");
        }

        private void Handle(Expr.LocalReference expr)
        {
            wl($"{Insn.Local.Get(expr.Decl.Index)}");
        }

        private void Handle(Expr.ParameterReference expr)
        {
            wl($"{Insn.Local.Get(expr.Decl.Index)}");
        }

        private void Handle(Expr.FunctionReference expr)
        {
            wl($"{Insn.CallStatic(expr.Decl.FullName())}");
        }

        private void Handle(Expr.CallFunction expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            Emit(expr.Function);
        }
    }
}
