using Six.Ceylon.Ast;
using Six.Runtime.Types;
using System.Reflection;

namespace Six.Ceylon.Walking
{
    public class Reflector
    {
        private readonly Dictionary<System.Type, Node> nodes = new();

        public Reflector()
        {
        }

        public Node Get(System.Type type)
        {
            if (!nodes.TryGetValue(type, out var node))
            {
                node = new Node(type);
                nodes.Add(type, node);
            }

            return node;
        }

        public class Node : IEnumerable<Node.Getter>
        {
            private readonly List<Getter> getters = new();

            public Node(System.Type type)
            {
                Type = type;
                Name = Type.Name;

                AddProperties(Type);
            }

            public System.Type Type { get; }
            public string Name { get; }

            public IEnumerator<Getter> GetEnumerator() => getters.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private void AddProperties(System.Type type)
            {
                var super = type.BaseType;

                if (super != null && typeof(AstNode).IsAssignableFrom(super))
                {
                    AddProperties(super);
                }

                var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var prop in props)
                {
                    if (typeof(RToken).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }
                    if (typeof(string).IsAssignableFrom(prop.PropertyType))
                    {
                        getters.Add(new Getter(prop));
                    }
                    else if (typeof(bool).IsAssignableFrom(prop.PropertyType))
                    {
                        getters.Add(new Getter(prop));
                    }
                    else if (typeof(AstNode).IsAssignableFrom(prop.PropertyType))
                    {
                        getters.Add(new Getter(prop));
                    }
                    else
                    {
                        Assert(false);
                    }
                }
            }

            public class Getter
            {
                public Getter(PropertyInfo prop)
                {
                    Prop = prop;
                    Name = Prop.Name;
                }

                public PropertyInfo Prop { get; }
                public string Name { get; }

                public object? Get(AstNode node)
                {
                    return Prop.GetValue(node);
                }
            }
        }
    }
}
