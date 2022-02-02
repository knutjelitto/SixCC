using Six.Ceylon.Ast;
using Six.Ceylon.Sema;

namespace Six.Ceylon.Walking
{
    public class Typer
    {
        private readonly IdentityDictionary<AstNode, Attr> Assoc = new();

        private class Attr
        {
            public int Count { get; set; }
        }

        public Typer(NamespaceScope root, Reflector reflector)
        {
            Root = root;
            Ref = reflector;
            Current = Root;
        }

        public NamespaceScope Root { get; }
        public NamespaceScope Current { get; private set; }
        public Reflector Ref { get; }


        public void Walk(AstNode ast)
        {
            if (ast != null)
            {
                Visit((dynamic)ast);
            }
        }

        private void Visit(Unit node)
        {
            Current = Root;

            Walk(node.Namespace);
            Walk(node.Declarations);
        }

        private void Visit(Namespace node)
        {
            Current = Root;

            foreach (var name in node.Names)
            {
                Current = Current.Open(name.Text);
            }
        }

        private void Visit(Declarations node)
        {
            foreach (var decl in node)
            {
                Walk(decl);
            }
        }

        private void Visit(Decl.Alias node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.Interface node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.Class node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.TypedMethod node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.VoidMethod node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.InferredMethod node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.TypedAttribute node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.InferredAttribute node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(Decl.Object node)
        {
            Current.Add(Dc.Create(node));
        }

        private void Visit(AstNode node)
        {
            throw new System.NotImplementedException($"Ast-Node of type ``{node.GetType().Name}´´ not implemented");
        }
    }
}
