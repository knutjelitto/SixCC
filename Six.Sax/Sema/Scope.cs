namespace Six.Sax.Sema
{
    public abstract class Scope : IScope
    {
        private readonly Dictionary<Ast.Name, It> items = new();
        private readonly Dictionary<Ast.Name, List<It>> dups = new();

        public bool Declare(It declaration)
        {
            var added = items.TryAdd(declaration.Name, declaration);

            Dup(!added, declaration);

            return added;
        }

        public IEnumerable<Dc> GetDups()
        {
            return dups.Values.SelectMany(l => l).OfType<Dc>();
        }

        public IEnumerable<Dc> GetDeclarations()
        {
            return items.Values.OfType<Dc>().OrderBy(dc => dc.Name);
        }

        private void Dup(bool isDup, It item)
        {
            if (isDup)
            {
                if (!dups.TryGetValue(item.Name, out var list))
                {
                    list = new List<It>();
                    dups.Add(item.Name, list);
                    list.Add(items[item.Name]);
                }
                list.Add(item);
            }
        }
    }
}
