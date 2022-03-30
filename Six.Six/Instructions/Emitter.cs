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
        public const string globalFunctionsTableName = "functionsTable";

        private readonly List<string> exports = new();

        private readonly List<Decl.Global> globals = new();
        private readonly Stack<Block> insns = new();
        private readonly Dumper dumper;
        public readonly TypeTable Types;
        public readonly StringData StringData;
        public readonly ClassData ClassData;
        public readonly FunctionTable GlobalFunctions;
        public readonly DispatchTable DispatchTable;

        public Emitter(Module module, Writer writer)
            : base(writer)
        {
            Module = module;
            dumper = new Dumper(this);
            Types = new TypeTable(this);
            StringData = new StringData(this, Module.DataAndHeap);
            ClassData = new ClassData(this, Module.DataAndHeap);
            GlobalFunctions = new FunctionTable(this, Module.ModuleFunctions);
            DispatchTable = new DispatchTable(this, Module.DispatchFunctions);
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
            wl($"(; {dumper.ClassyHead(decl)} ;)");
            indent(() =>
            {
                dumper.WriteLayout(decl);

                if (decl is Decl.Class clazz)
                {
                    EmitInitCtor(clazz);
                }
                
                foreach (var member in decl.Block.Members)
                {
                    Emit(member);
                }
            });
        }

        public void EmitInitCtor(Decl.Class clazz)
        {
            if (clazz.IsNative)
            {
                // nothing to emit
                return;
            }

            wl($"(func ${clazz.FullName}.{Module.InitCtor}");
            indent(() =>
            {
                wl($"(param (;0/self:{clazz.Name};) i32)");

                wl("(;-----;)");
                var get = Insn.Local.Get(0);
                foreach (var field in clazz.Layout.Fields.Select(f => f.Field))
                {
                    Emit(get);
                    Emit(field.Value);
                    Emit(Lower(field.Type).Store(field.Offset));
                }
                Emit(Insn.Return);
                wl("(;-----;)");
            });
            wl($")");
        }


        private void Handle(Decl.Alias decl)
        {
            Assert(false);
        }

        private void Handle(Decl.SelfParameter decl)
        {
            Assert(true);
        }

        private void Handle(Decl.Parameter decl)
        {
            Assert(true);
        }

        public void EmitFuncy(Decl.Funcy funcy)
        {
            if (funcy is Decl.Constructor ctor && ctor.IsNative)
            {
                // nothing to emit
                return;
            }

            foreach (var inner in funcy.InnerFunctions())
            {
                EmitFuncy(inner);
            }

            wl($"(func ${funcy.FullName}");
            indent(() =>
            {
                if (funcy.IsShared) wl(Export(funcy));

                funcy.Layout.EmitDeclarations();

                wl("(;-----;)");
                if (funcy is Decl.Constructor ctor && ctor.Parent is ClassBlock classBlock && classBlock.Classy is Decl.Class clazz)
                {
                    Emit(Insn.Local.Get(0));
                    Emit(Insn.Call($"{clazz.FullName}.{Module.InitCtor}"));
                }

                foreach (var member in funcy.Block.Members)
                {
                    if (member is Decl.Funcy)
                    {
                        continue;
                    }

                    Emit(member);
                }
                wl("(;-----;)");
            });
            wl($")");
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
