using Six.Core;
using Six.Core.Errors;
using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Global
    {
        private readonly IdentityDictionary<Node, IScope> Where = new();
        private readonly List<Diagnostic> Diagnostics = new();
        private readonly Queue<(IScope, IResolveable)> Resolveables = new();

        public Global()
        {
            Root = new NamespaceScope(this, null, "");
        }

        public NamespaceScope Root { get; }

        public NamespaceScope Open(IEnumerable<string> names)
        {
            var current = Root;
            foreach (var name in names)
            {
                current = current.Open(name);
            }
            return current;
        }

        public void Add(Diagnostic diagnostic)
        {
            Diagnostics.Add(diagnostic);
        }

        public void Add(IScope scope, IResolveable resolveable)
        {
            Resolveables.Enqueue((scope, resolveable));
        }

        public void InScope(IScope scope, Node node)
        {
            Where.Add(node, scope);
        }

        public void Dump(Writer writer)
        {
            Root.Dump(writer);

            if (Diagnostics.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("==========");
                foreach (var diagnostic in Diagnostics)
                {
                    diagnostic.Report(writer);
                }
            }
        }
    }
}
