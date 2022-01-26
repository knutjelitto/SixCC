using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public class Namespace : INamespace, IBodyOwner
    {
        private readonly Dictionary<Identifier, Namespace> children = new();

        public Namespace(Identifier? name = null)
        {
            Name = name;
            Body = new Body(this);
        }

        public Identifier? Name { get; }

        public IBody Body { get; }

        public INamespace Create(Identifier name)
        {
            if (!children.TryGetValue(name, out var @namespace))
            {
                @namespace = new Namespace(name);
                children.Add(name, @namespace);
            }
            return @namespace;
        }

        public IEnumerator<INamespace> GetEnumerator() => children.Values.OrderBy(x => x.Name).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Dump(Writer writer)
        {
            Dump(writer, "::");
        }

        protected void Dump(Writer writer, string prefix)
        {
            if (Body.DeclarationCount > 0)
            {
                writer.WriteLine($"{prefix}");
                using (writer.Indent())
                {
                    Body.Dump(writer);
                }
            }

            if (prefix == "::")
            {
                prefix = string.Empty;
            }
            else
            {
                prefix += ".";
            }
            foreach (var ns in this)
            {
                ((Namespace)ns).Dump(writer, prefix + ns.Name!.ToString());
            }
        }
    }
}
