using Six.Core;
using Six.Runtime;
using Six.Six.Ast;

namespace Six.Six.Compiler
{
    public class AstDumper : WithWriter
    {
        public AstDumper(Writer writer, Reflector reflector)
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

        private void Dump(string name, Name token)
        {
            wl($"{name} : {token.GetType().Name} = {token.Text.Esc()}");
        }

        private void Dump(string name, Expression.String str)
        {
            wl($"{name} : {str.GetType().Name} = {str.Text.ShortEsc(100)}");
        }

        private void Dump(string name, Expression.NaturalNumber str)
        {
            wl($"{name} : {str.GetType().Name} = {str.Text}");
        }

        private void Dump(string name, TreeNode astNode)
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

        private void Dump(string name, NodeList list)
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
