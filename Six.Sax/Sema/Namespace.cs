using Six.Core;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Namespace : Scope, Container, Contained
    {
        private readonly Dictionary<string, Namespace> children = new();

        public Namespace(Module module, Container container, string name)
            : base(module)
        {
            Container = container;
            Name = name;
        }

        public string Name { get; }
        public Container Container { get; }

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
            if (Container is Namespace ns)
            {
                if (ns.GetPath().EndsWith("::"))
                    return "::" + Name;

                return (ns.GetPath() + "." + Name).TrimStart('.');
            }
            else
            {
                return ((Module)Container).Name;
            }
        }

        public IEnumerable<Namespace> GetNamespaces()
        {
            foreach (var child in children.Values)
            {
                yield return child;
                foreach (var childchild in child.GetNamespaces())
                {
                    yield return childchild;
                }
            }
        }
    }
}
