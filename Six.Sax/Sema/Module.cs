using Six.Core;
using Six.Core.Errors;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Module : Container
    {
        private readonly List<Diagnostic> Diagnostics = new();

        public Module()
        {
            Root = new Namespace(this, this, "");
            Name = "::";
        }

        public Namespace Root { get; }
        public string Name { get; }

        Module Container.Module => this;

        public IReadOnlyList<Entity> Entities => Enumerable.Empty<Entity>().ToList();

        public Container Open(A.Namespace @namespace)
        {
            var current = Root;
            foreach (var name in @namespace.Names)
            {
                current = current.Open(name.Text);
            }
            return current;
        }

        public void Add(Diagnostic diagnostic)
        {
            Diagnostics.Add(diagnostic);
        }

        public IEnumerable<Namespace> GetNamespaces()
        {
            return Root.GetNamespaces();
        }

        public void Dump(Writer writer)
        {
            foreach (var ns in Root.GetNamespaces())
            {
                if (ns.Entities.Count > 0)
                {
                    writer.WriteLine(ns.GetPath());

                    ns.Dump(writer);
                }
            }

            if (Diagnostics.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("========== ERROR");
                foreach (var diagnostic in Diagnostics)
                {
                    diagnostic.Report(writer);
                }
            }

            writer.WriteLine();
            writer.WriteLine("========== DEFINED");
            this.DumpReferences(writer);
        }

        public void Add(Entity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
