namespace Six.Ceylon.Sema
{
    public abstract class Scope : IScope
    {
        private readonly Dictionary<Ast.Identifier, Dc> declarations = new();
        private readonly Dictionary<Ast.Identifier, List<Dc>> dups = new();

        public bool Declare(Dc declaration)
        {
            var added = declarations.TryAdd(declaration.Name, declaration);

            Dup(!added, declaration);

            return added;
        }

        public IEnumerable<Dc> GetDups()
        {
            return dups.Values.SelectMany(l => l);
        }

        public IEnumerable<Dc> GetDeclarations()
        {
            var lower = declarations.Values.Where(dc => dc.Name is Ast.Identifier.Lower).OrderBy(dc => dc.Name.Text);
            var upper = declarations.Values.Where(dc => dc.Name is Ast.Identifier.Upper).OrderBy(dc => dc.Name.Text);

            return lower.Concat(upper);
        }

        private void Dup(bool isDup, Dc declaration)
        {
            if (isDup)
            {
                if (!dups.TryGetValue(declaration.Name, out var list))
                {
                    list = new List<Dc>();
                    dups.Add(declaration.Name, list);
                    list.Add(declarations[declaration.Name]);
                }
                list.Add(declaration);
            }
        }
    }
}
