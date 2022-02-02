namespace Six.Ceylon.Sema
{
    public class NamespaceScope : Scope
    {
        private readonly Dictionary<string, NamespaceScope> children = new();

        public NamespaceScope(NamespaceScope? parent, string name)
        {
            Parent = parent;
            Name = name;
        }

        public NamespaceScope? Parent { get; }
        public string Name { get; }

        public NamespaceScope Open(string name)
        {
            if (!children.TryGetValue(name, out var scope))
            {
                scope = new NamespaceScope(this, name);
                children.Add(name, scope);
            }
            return scope;
        }

        public void Dump(Writer writer)
        {
            Dump("", writer);
        }

        private void Dump(string prefix, Writer writer)
        {
            if (prefix.Length > 0)
            {
                prefix = $"{prefix}.{Name}";
            }
            else
            {
                prefix = Name;
            }

            if (prefix.Length > 0)
            {
                writer.WriteLine(prefix);

                using (writer.Indent())
                {
                    foreach (var dc in GetDeclarations())
                    {
                        var attrs = dc.IsShared ? "[S]" : "[ ]";

                        writer.WriteLine($"{dc.Kind,-15} {attrs}{dc.Name.Text} - {dc.Location}");
                    }
                    var dups = GetDups().ToList();
                    if (dups.Count > 0)
                    {
                        writer.WriteLine("---");
                        foreach (var dc in dups)
                        {
                            writer.WriteLine($"{dc.Kind,-15} {dc.Name.Text} - {dc.Location}");
                        }
                    }
                }
            }

            foreach (var ns in children.Values.OrderBy(ns => ns.Name))
            {
                ns.Dump(prefix, writer);
            }
        }
    }
}
