using Six.Sax.Ast;
using System;

namespace Six.Sax.Sema
{
    public interface Dc : It
    {
        Prelude Prelude { get; }
        string Kind { get; }
        Location Location { get; }
        bool IsShared { get; }

        public static void Declare(IScope scope, Declaration.Entity declaration)
        {
            var dc = new Named(scope, declaration);

            scope.Declare(dc);
        }

        private record Named(IScope Scope, Declaration.Entity Declaration) : Dc
        {
            private bool? isShared = null;
            private Location? location = null;

            public Name Name => Declaration.Name;
            public Prelude Prelude => Declaration.Prelude;
            public string Kind => Declaration.GetType().Name;
            public Location Location => location ??= Location.From(Name.Tree);

            public bool IsShared => (isShared ??= Prelude.Attributes.Any(a => a.Name.Text == "shared"));
        }
    }
}
