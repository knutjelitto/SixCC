using Six.Core;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Namespace : Scope, Container
    {
        private readonly Dictionary<string, Namespace> children = new();

        public Namespace(Module module, Namespace? parent, string name)
            : base(module)
        {
            Parent = parent;
            Name = name;
        }

        public Namespace? Parent { get; }
        public string Name { get; }

        public Namespace Open(string name)
        {
            if (!children.TryGetValue(name, out var scope))
            {
                scope = new Namespace(Module, this, name);
                children.Add(name, scope);
            }
            return scope;
        }

        public string GetPath()
        {
            if (Parent == null)
            {
                return "";
            }
            return (Parent.GetPath() + "." + Name).TrimStart('.');
        }

        public IEnumerable<Namespace> EnumerateChildren()
        {
            foreach (var child in children.Values)
            {
                yield return child;
                foreach (var childchild in child.EnumerateChildren())
                {
                    yield return childchild;
                }
            }
        }


        public void DumpP(Writer writer)
        {
            //DumpP("", writer);
        }

        private void DumpP(string prefix, Writer writer)
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

                this.DumpDeclarations(writer);
            }
        }
    }
}
