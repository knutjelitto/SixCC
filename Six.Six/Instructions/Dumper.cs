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
            comment2(() =>
            {
                Walker(classy);
            });
        }

        private void comment2(Action action)
        {
            indent("(; (; ;)", ";)", action);
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
            indent(() =>
            {
                foreach (var member in block.Members)
                {
                    Walker(member);
                }
            });
        }

        private void WalkMethods(Block block)
        {
            indent(() =>
            {
                foreach (var member in block.Members.OfType<Decl.Funcy>())
                {
                    Walker(member);
                }
            });
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
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            indent(() => WriteLayout(decl));
            WalkMethods(decl.Block);
        }

        private void WriteLayout(Decl.Classy decl)
        {
            var layout = decl.Layout;
            Assert(layout.Done);

            if (layout.Fields.Count > 0)
            {
                comment("fields", () =>
                {
                    foreach (var field in layout.Fields)
                    {
                        wl($"+{field.Offset,-3} field {field.Name} {Emitter.Lower(field.Type).Wasm.Type} = ...");
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