namespace Six.Ceylon.Sema
{
    public interface Dc
    {
        Ast.Identifier Name { get; }
        Ast.Annotations Annotations { get; }
        string Kind { get; }
        string Location { get; }
        bool IsShared { get; }

        public static Dc Create(Ast.Decl declaration)
        {
            return new Named(declaration);
        }

        private record Named(Ast.Decl Declaration) : Dc
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
