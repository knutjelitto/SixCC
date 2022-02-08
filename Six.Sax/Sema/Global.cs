using Six.Core;
using Six.Core.Errors;
using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Global
    {
        public readonly IdentityDictionary<Node, IScope> DeclaredIn = new();
        public readonly IdentityDictionary<Node, IScope> ResolveIn = new();
        public readonly IdentityDictionary<Node, Node> ResolvedTo = new();

        private readonly List<Diagnostic> Diagnostics = new();
        private readonly Queue<IResolveable> Resolveables = new();

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

        public void ToResolve(IScope scope, IResolveable resolveable)
        {
            ResolveIn.Add(resolveable, scope);
            Resolveables.Enqueue(resolveable);
        }

        public void DeclareIn(IScope scope, Node node)
        {
            DeclaredIn.Add(node, scope);
        }

        public void Resolve()
        {
            var resolver = new ResolveWalker(this);

            while (Resolveables.Count > 0)
            {
                var node = Resolveables.Dequeue();
                resolver.Walk(node);
            }
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
