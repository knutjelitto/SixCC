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
        private readonly Dictionary<string, (uint index, Decl.Function function)> globalFunctionTable = new();

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
        }

        private Module Module { get; }
        private Resolver Resolver => Module.Resolver;
        private Builtins.Builtins Builtins => Module.Builtins;

        public void Emit(Entity entity)
        {
            Handle((dynamic)entity);
        }

        public void EmitModule()
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
                Vertical(exports.Select(export => new Action(() => wl(export))));
                wl();
                VerticalSpaced(functions.Select(function => function));
                if (globalFunctionTable.Count > 0)
                {
                    wl();
                    wl($"(table $table {globalFunctionTable.Count} anyfunc)");
                    foreach (var (name, element) in globalFunctionTable)
                    {
                        wl($"(elem (table $table) ({Insn.U32.Const(element.index)}) ${name})");
                    }
                }
            });
            wl($")");
        }

        private void Handle(Entity entity)
        {
            Assert(false);
        }

        private void Handle(Decl.Attribute decl)
        {
            Assert(true);
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
                    Horizontal(decl.Parameters.Select(param => new Action(() => w($"{Param(param)}"))));

                    wlif(Result(decl.Result!));

                    Horizontal(decl.Locals.Select(local => new Action(() => w($"{Local(local)}"))));

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

        private void Handle(Decl.Var decl)
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
            wl($"{Insn.Local.Get(expr.LocalDecl.Index)}");
        }

        private void Handle(Expr.ParameterReference expr)
        {
            wl($"{Insn.Local.Get(expr.ParameterDecl.Index)}");
        }

        private void Handle(Expr.FunctionReference expr)
        {
            var function = expr.FunctionDecl;
            var name = function.FullName();

            uint index = 0;
            if (!globalFunctionTable.TryGetValue(name, out var entry))
            {
                index = (uint)globalFunctionTable.Count;
                globalFunctionTable.Add(name, (index, function));
            }
            else
            {
                index = entry.index;
            }

            wl($"{Insn.U32.Const(index)}");

            //wl($"{Insn.CallStatic(expr.FunctionDecl.FullName())}");
        }

        private void Handle(Expr.SelectAttribute expr)
        {
            wl($"TODO: select attribute");
        }

        private void Handle(Expr.CallFunction expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            wl($"{Insn.CallStatic(expr.Function.FunctionDecl.FullName())}");
        }
    }
}
