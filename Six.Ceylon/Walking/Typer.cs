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

        public Typer(Sema.Context context)
        {
            Context = context;
            Current = Root;
        }

        public Sema.Context Context { get; }
        public NamespaceScope Root => Context.Root;
        public Reflector Ref => Context.Reflector;
        public IScope Current
        {
            get => Context.Current;
            set => Context.Current = value;
        }

        public void Walk(AstNode ast)
        {
            if (ast != null)
            {
                Visit((dynamic)ast);
            }
        }

        private void Visit(Unit node)
        {
            Walk(node.Namespace);
            Walk(node.Imports);
            Walk(node.Declarations);
        }

        private void Visit(Namespace node)
        {
            var current = Root;

            foreach (var name in node.Names)
            {
                current = current.Open(name.Text);
            }

            Current = current;
        }

        private void Visit(Imports node)
        {
            foreach (var import in node)
            {
                Walk(import);
            }
        }

        private void Visit(Import node)
        {
            var path = string.Join(".", node.Path.Select(x => x.Text));
            var location = node.Path[0].Location;

            Context.AddImport(path, location);
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
            Dc.Create(Context, node);
        }

        private void Visit(Decl.Interface node)
        {
            using (Dc.Create(Context, node))
            {
                Walk(node.Definition);
            }
        }

        private void Visit(Decl.Class node)
        {
            using (Dc.Create(Context, node))
            {
                Walk(node.Definition);
            }
        }

        private void Visit(Decl.Object node)
        {
            using (Dc.Create(Context, node))
            {
                Walk(node.Definition);
            }
        }

        private void Visit(Decl.Constructor node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Decl.TypedMethod node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Decl.VoidMethod node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Decl.InferredMethod node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Decl.TypedAttribute node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Decl.InferredAttribute node)
        {
            Dc.Create(Context, node);
        }

        private void Visit(Block node)
        {
            Walk(node.Imports);
            Walk(node.Statements);
        }

        private void Visit(Statements node)
        {
            foreach (var statement in node)
            {
                Walk(statement);
            }
        }

        private void Visit(Stmt node)
        {
            //TODO: generic statement
        }

        private void Visit(AstNode node)
        {
            throw new System.NotImplementedException($"Ast-Node of type ``{node.GetType().Name}´´ not implemented");
        }

        public void Dump(Writer writer)
        {
            Root.Dump(writer);
            Context.DumpImports(writer);
        }
    }
}
