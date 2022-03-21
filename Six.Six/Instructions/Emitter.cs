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

        private readonly List<Decl.Global> globals = new();
        private readonly Stack<Block> insns = new();
        private readonly Dumper dumper;
        public readonly TypeTable Types;
        public readonly StringData StringData;
        public readonly ClassData ClassData;
        public readonly FunctionTable GlobalFunctions;
        public readonly Prepper Prepper;

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
            dumper = new Dumper(this, writer);
            Types = new TypeTable(this);
            StringData = new StringData(writer, Module.DataAndHeap);
            ClassData = new ClassData(this, Module.DataAndHeap);
            GlobalFunctions = new FunctionTable(writer, globalFunctionsTableName);
            Prepper = new Prepper(this, writer);
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;
        public Builtins.Builtins Builtins => Module.Builtins;

        public void Emit(Entity entity)
        {
            Handle((dynamic)entity);
        }

        private void Emit(Insn insn)
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
            foreach (var member in decl.Block.Members)
            {
                Emit(member);
            }
        }

        private void Handle(Decl.Alias decl)
        {
            Assert(true);
        }

        private void Handle(Decl.SelfParameter decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Parameter decl)
        {
            Assert(true);
        }

        public void EmitFuncy(Decl.Funcy funcy, bool isCtor = false)
        {
            wl($"(func ${funcy.FullName}");
            indent(() =>
            {
                if (funcy.IsShared) wl(Export(funcy));

                wl($"{Params(funcy.Parameters)}");

                wlif(Result(funcy.ResultType));

                Horizontal(funcy.Locals.Select(local => new Action(() => w($"{Local(local)}"))));

                wl("(;-----;)");
                foreach (var member in funcy.Block.Members)
                {
                    Emit(member);
                }
                if (isCtor)
                {
                    Assert(funcy.Parameters.Count > 0);
                    Emit(funcy.Parameters[0]);
                    Emit(Insn.ToDo("return object"));
                }
                wl("(;-----;)");
            });
            wl($")");
        }

        private void Handle(Decl.Constructor decl)
        {
            EmitFuncy(decl, true);
        }

        private void Handle(Decl.Funcy decl)
        {
            EmitFuncy(decl);
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
