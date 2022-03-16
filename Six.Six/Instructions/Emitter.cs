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

        private readonly List<Decl.Global> globals = new();

        private readonly Stack<Block> insns = new();

        private readonly Dumper dumper;

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
            dumper = new Dumper(this, writer);
        }

        private Module Module { get; }
        private Resolver Resolver => Module.Resolver;
        private Builtins.Builtins Builtins => Module.Builtins;

        public void Emit(Entity entity)
        {
            Handle((dynamic)entity);
        }

        public void Emit(Insn insn)
        {
            wl($"{insn}");
        }

        private void Handle(Entity entity)
        {
            Assert(false);
        }

        private void Handle(Decl.Attribute decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Field decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Global decl)
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

        public void EmitFuncy(Decl.Funcy decl)
        {
            wl($"(func ${decl.Container.FullName}");
            indent(() =>
            {
                wl(Export(decl));

                wl($"{Params(decl.Parameters)}");

                if (decl is Decl.Function func)
                {
                    wlif(Result(func.ResultType));
                }

                Horizontal(decl.Locals.Select(local => new Action(() => w($"{Local(local)}"))));

                wl("(;-----;)");
                foreach (var member in decl.Members)
                {
                    Emit(member);
                }
                wl("(;-----;)");
            });
            wl($")");
        }

        private void Handle(Decl.Funcy decl)
        {
            functions.Add(() =>
            {
                EmitFuncy(decl);
            });
        }

        private void Handle(Decl.LetVar decl)
        {
            if (decl.Value != null)
            {
                Emit(decl.Value);
                Emit(Insn.Local.Set(decl.Index));
            }
            else
            {
                Assert(false);
            }
        }
    }
}
