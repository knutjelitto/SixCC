using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter : WithWriter
    {
        public const string globalFunctionsTableName = "$functionsTable";

        private readonly List<string> exports = new();
        private readonly List<Action> functions = new();
        private readonly Dictionary<string, (uint index, Decl.Function function)> globalFunctionsTable = new();
        private readonly Dictionary<string, uint> functionTypes = new();

        private readonly Stack<Block> insns = new();

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
    }
}
