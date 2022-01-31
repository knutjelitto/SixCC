using Six.Ceylon.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Walking
{
    internal class Reflector : WithWriter
    {
        private readonly Dictionary<System.Type, Node> nodes = new Dictionary<System.Type, Node>();

        public Reflector(Writer writer)
            : base(writer)
        {
        }

        public void Reflect(object? ast)
        {
            if (ast is AstNode astNode)
            {
                var node = Get(astNode.GetType());

                foreach (var getter in node)
                {
                    wl($"{getter.Name,-20}");

                    indent(() =>
                    {
                        Reflect(getter.Get(astNode));
                    });
                }
            }
        }

        private Node Get(System.Type type)
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

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    if (typeof(AstNode).IsAssignableFrom(prop.PropertyType))
                    {
                        getters.Add(new Getter(prop));
                    }
                    else
                    {
                        Assert(false);
                    }
                }
            }

            public System.Type Type { get; }
            public string Name { get; }

            public IEnumerator<Getter> GetEnumerator() => getters.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public class Getter
            {
                public Getter(PropertyInfo prop)
                {
                    Prop = prop;
                    Name = Prop.Name;
                }

                public PropertyInfo Prop { get; }
                public string Name { get; }

                public AstNode? Get(AstNode node)
                {
                    return Prop.GetValue(node) as AstNode;
                }
            }
        }
    }
}
