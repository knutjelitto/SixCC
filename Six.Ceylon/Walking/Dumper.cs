using Six.Ceylon.Ast;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Dispatch("Top", ast);
        }

        public void DumpX(string name, object? ast)
        {
            Dispatch(name, ast);
        }

        private void Dispatch(string name, object? ast)
        {
            if (ast != null)
            {
                Dump(name, (dynamic)ast);
            }
        }

        private void Dump(string name, object obj)
        {
            w(name);

            wl($" = {obj}");

            Assert(false);
        }

        private void Dump(string name, string str)
        {
            wl($"{name} = {str}");
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
                    Dispatch($"{getter.Name}", value);
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
                        Dispatch($"[{index++}]", item);
                    }
                });
            }
        }
    }
}
