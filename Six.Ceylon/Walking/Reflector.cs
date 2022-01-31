using Six.Ceylon.Ast;
using Six.Runtime.Types;
using System.Reflection;

namespace Six.Ceylon.Walking
{
    internal class Reflector : WithWriter
    {
        private readonly Dictionary<System.Type, Node> nodes = new();

        public Reflector(Writer writer)
            : base(writer)
        {
        }

        public void Reflect(object? ast)
        {
            if (ast is AstList astList)
            {
                wl($" : {astList.GetType().Name}[*]");
                indent(() =>
                {
                    var index = 0;
                    foreach (var item in astList.Items)
                    {
                        w($"[{index++}]");
                        Reflect(item);
                    }
                });
            }
            else if (ast is AstNode astNode)
            {
                var node = Get(astNode.GetType());

                w($" : {node.Type.Name}");
                if (astNode is Identifier token)
                {
                    wl($" = {token.Text.Esc()}");
                }
                else if (astNode is String str)
                {
                    wl($" = {str.Text.Substring(0, System.Math.Min(str.Text.Length, 200)).Esc()}");
                }
                else
                {
                    wl();
                    indent(() =>
                    {
                        foreach (var getter in node)
                        {
                            var value = getter.Get(astNode);
                            w($"{getter.Name}");
                            Reflect(value);
                        }
                    });
                }
            }
            else if (ast != null)
            {
                wl($"{ast}");
                Assert(false);
            }
            else
            {
                wl();
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

                AddProperties(Type);
            }

            public System.Type Type { get; }
            public string Name { get; }

            public IEnumerator<Getter> GetEnumerator() => getters.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private void AddProperties(System.Type type)
            {
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    if (typeof(string).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }
                    if (typeof(bool).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }
                    if (typeof(int).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }
                    if (typeof(RToken).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }
                    if (typeof(AstNode).IsAssignableFrom(prop.PropertyType))
                    {
                        getters.Add(new Getter(prop));
                        continue;
                    }

                    Assert(false);
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
