using Six.Ceylon.Ast;

namespace Six.Ceylon.Walking
{
    public class Dumper : WithWriter
    {
        public Dumper(Writer writer, Reflector reflector)
            : base(writer)
        {
            Ref = reflector;
        }

        public Reflector Ref { get; }

        public void Dump(object? ast)
        {
            Walk("Top", ast);
        }

        private void Walk(string name, object? ast)
        {
            if (ast != null)
            {
                Dump(name, (dynamic)ast);
            }
        }

        private void Dump(string name, object obj)
        {
            wl($"{name} = {obj}");

            Assert(false);
        }

        private void Dump(string name, string @string)
        {
            wl($"{name} = {@string}");
        }

        private void Dump(string name, bool @bool)
        {
            wl($"{name} = {@bool}");
        }

        private void Dump(string name, Identifier token)
        {
            wl($"{name} : {token.GetType().Name} = {token.Text.Esc()}");
        }

        private void Dump(string name, String str)
        {
            wl($"{name} : {str.GetType().Name} = {str.Text.ShortEsc(100)}");
        }

        private void Dump(string name, AstNode astNode)
        {
            var node = Ref.Get(astNode.GetType());

            wl($"{name} : {node.Type.Name}");
            indent(() =>
            {
                foreach (var getter in node)
                {
                    var value = getter.Get(astNode);
                    Walk($"{getter.Name}", value);
                }
            });
        }

        private void Dump(string name, AstList list)
        {
            if (list.Count > 0)
            {
                wl($"{name} : {list.GetType().Name}[#{list.Count}]");
                indent(() =>
                {
                    var index = 0;
                    foreach (var item in list.Items)
                    {
                        Walk($"[{index++}]", item);
                    }
                });
            }
        }
    }
}
