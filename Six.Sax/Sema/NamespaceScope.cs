using Six.Core;

namespace Six.Sax.Sema
{
    public class NamespaceScope : Scope
    {
        private readonly Dictionary<string, NamespaceScope> children = new();

        public NamespaceScope(Global global, NamespaceScope? parent, string name)
            : base(global)
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
                scope = new NamespaceScope(Global, this, name);
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
                writer.WriteLine($"namespace {prefix}:");

                using (writer.Indent())
                {
                    foreach (var dc in GetDeclarations())
                    {
                        var attrs = new StringBuilder();
                        attrs.Append(dc.IsShared() ? "S" : " ");
                        attrs.Append(dc.IsNative() ? "N" : " ");

                        writer.WriteLine($"{dc.GetKind(),-15} [{attrs}] {dc.Name.Text} - {dc.GetLocation()}");
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
