using System;

namespace Six.Ceylon.Sema
{
    public interface Dc
    {
        Ast.Identifier Name { get; }
        Ast.Annotations Annotations { get; }
        string Kind { get; }
        string Location { get; }
        bool IsShared { get; }

        public static IDisposable Create(Context context, Ast.Decl declaration)
        {
            var scope = new DeclarationScope(context.Current);

            var dc = new Named(context, scope, declaration);

            context.Current.Declare(dc);

            return context.Push(scope);
        }

        private record Named(Context Context, IScope Scope, Ast.Decl Declaration) : Dc
        {
            private bool? isShared = null;

            public Ast.Identifier Name => Declaration.Name;
            public Ast.Annotations Annotations => Declaration.Annotations;
            public string Kind => Declaration.GetType().Name;
            public string Location => Declaration.Location;

            public bool IsShared => (isShared ??= Annotations.Items.Any(a => a.Name.Text == "shared"));
        }
    }
}
