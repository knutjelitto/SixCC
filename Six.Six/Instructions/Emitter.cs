using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

namespace Six.Six.Instructions
{
    public partial class Emitter : WithWriter
    {
        public const string globalFunctionsTableName = "$functionsTable";

        private readonly List<string> exports = new();
        private readonly List<Action> functions = new();
        private readonly Dictionary<string, (uint index, Decl.Function function)> globalFunctionsTable = new();
        private readonly Dictionary<string, uint> functionTypes = new();

        private readonly Dumper dumper;

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
            dumper = new Dumper(writer);
        }

        private Module Module { get; }
        private Resolver Resolver => Module.Resolver;
        private Builtins.Builtins Builtins => Module.Builtins;

        public void Emit(Entity entity)
        {
            Handle((dynamic)entity);
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
            //exports.Add($"(export \"{decl.Container.FullName}\" (func ${decl.Container.FullName}))");

            functions.Add(() =>
            {
                wl($"(func ${decl.Container.FullName}");
                indent(() =>
                {
                    wl($"(export \"{decl.Container.FullName}\")");
                    wl("(;-----;)");

                    Horizontal(decl.Parameters.Select(param => new Action(() => w($"{Param(param)}"))));

                    wlif(Result(decl.ResultType!));

                    Horizontal(decl.Locals.Select(local => new Action(() => w($"{Local(local)}"))));

                    wl("(;-----;)");
                    foreach (var member in decl.Members)
                    {
                        Emit(member);
                    }
                    wl("(;-----;)");
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
            var name = function.FullName;

            uint index = 0;
            if (!globalFunctionsTable.TryGetValue(name, out var entry))
            {
                index = (uint)globalFunctionsTable.Count;
                globalFunctionsTable.Add(name, (index, function));
            }
            else
            {
                index = entry.index;
            }

            wl($"{Insn.U32.Const(index)}");
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
            wl($"{Insn.Call(expr.Function.FunctionDecl.FullName)}");
        }

        private void Handle(Expr.CallIndirect expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            var callable = expr.Callable;

            Emit(expr.Value);
            wl($"{Insn.CallIndirect(globalFunctionsTableName)} (type {FindType(callable)})");
        }
    }
}
