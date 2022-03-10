using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

namespace Six.Six.Instructions
{
    public class Dumper : WithWriter
    {
        public Dumper(Writer writer)
            : base(writer)
        {
        }

        public void Dump(Decl.Classy classy)
        {
            comment(() =>
            {
                Walker(classy);
            });
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

        private void Walk(Decl.Classy decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}");
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

        private void comment(Action action)
        {
            indent("(;", ";)", action);
        }
    }
}