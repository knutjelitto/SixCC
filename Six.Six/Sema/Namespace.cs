using Six.Core;
using Six.Runtime.Types;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Namespace : ContainerCore
    {
        private readonly Dictionary<string, Namespace> children = new();

        public Namespace(string name, Container parent)
            : base(parent)
        {
            Name = name;
        }

        public string Name { get; }

        public override Declarations Resolve(A.Reference reference)
        {
            return Find(reference, reference.Name.Text);
        }

        public Namespace Open(string name)
        {
            if (!children.TryGetValue(name, out var scope))
            {
                scope = new Namespace(name, this);
                children.Add(name, scope);
            }
            return scope;
        }

        public Namespace? Get(string name)
        {
            if (children.TryGetValue(name, out var ns))
            {
                return ns;
            }
            return null;
        }

        public string GetPath()
        {
            if (Parent is Namespace parent)
            {
                return (parent.GetPath() + "." + Name).TrimStart('.');
            }
            else
            {
                return "";
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
