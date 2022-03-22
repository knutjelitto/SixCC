using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE1006 // Naming Styles

namespace Six.Six.Instructions
{
    public class Dumper : WithWriter
    {
        public Emitter Emitter { get; }

        public Dumper(Emitter emitter, Writer writer)
            : base(writer)
        {
            Emitter = emitter;
        }

        public void Dump(Decl.Classy classy)
        {
            comment($"(; {ClassyHead(classy)} ;)", () =>
            {
                Walker(classy);
            });
        }

        private void comment(string title, Action action)
        {
            indent($"(; {title}", ";)", action);
        }

        private void Walker(Entity decl)
        {
            Walk((dynamic)decl);
        }

        private void Walk(Entity decl)
        {
            Assert(false);
        }

        private void WalkMembers(Block block)
        {
            foreach (var member in block.Members)
            {
                Walker(member);
            }
        }

        private void WalkMethods(Block block)
        {
            foreach (var member in block.Members.OfType<Decl.Funcy>())
            {
                Walker(member);
            }
        }

        private string Extends(Decl.Classy decl)
        {
            if (decl.Extends != null)
            {
                return $" : {decl.Extends}";
            }
            return "";
        }

        private void WalkClassy(Decl.Classy decl)
        {
            WriteLayout(decl);
            WalkMethods(decl.Block);
        }

        public string ClassyHead(Decl.Classy decl)
        {
            return $"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}";
        }

        public void WriteLayout(Decl.Classy decl)
        {
            var layout = decl.Layout;
            Assert(layout.Done);

            if (layout.Fields.Count > 0)
            {
                comment("fields", () =>
                {
                    foreach (var field in layout.Fields)
                    {
                        wl($"+{field.Field.Offset,-3} field {field.Field.Name} {Emitter.Lower(field.Field.Type).Wasm.Type} = ...");
                    }
                });
            }
            if (layout.Slots.Count > 0)
            {
                comment("slots", () =>
                {
                    foreach (var slot in layout.Slots)
                    {
                        wl($"{slot.Index,-3} slot {slot.Funcy.FullName}");
                    }
                });
            }
        }

        private void Walk(Decl.Class decl)
        {
            WalkClassy(decl);
        }

        private void Walk(Decl.Interface decl)
        {
            WalkClassy(decl);
        }

        private void Walk(Decl.Object decl)
        {
            WalkClassy(decl);
        }

        private void Walk(Decl.Attribute decl)
        {
            wl($"(; attribute ;)");
            Emitter.EmitFuncy(decl);
        }

        private void Walk(Decl.Field decl)
        {
            wl($"field {decl.FullName}");
        }

        private void Walk(Decl.Funcy decl)
        {
            Emitter.EmitFuncy(decl);
        }

        private void Walk(Stmt stmt)
        {
            Emitter.Emit(stmt);
        }
    }
}