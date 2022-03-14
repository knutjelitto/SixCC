using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

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
            comment(() =>
            {
                Walker(classy);
            });
        }

        private void comment(Action action)
        {
            indent("(;", ";)", action);
        }

        private void Walker(Entity decl)
        {
            Walk((dynamic)decl);
        }

        private void Walk(Entity decl)
        {
            Assert(false);
        }

        private void WalkMembers(Decl.WithMembers decl)
        {
            indent(() =>
            {
                foreach (var member in decl.Members)
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

        private void Walk(Decl.Classy decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Class decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Object decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Attribute decl)
        {
            wl($"attribute {decl.FullName}");
        }

        private void Walk(Decl.Funcy decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}");
            WalkMembers(decl);
        }

        private void Walk(Stmt stmt)
        {
            Emitter.Emit(stmt);
        }

    }
}