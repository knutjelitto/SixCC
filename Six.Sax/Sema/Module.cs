using Six.Core;
using Six.Core.Errors;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Module
    {
        public readonly IdentityDictionary<A.TreeNode, IScope> DeclaredIn = new();
        public readonly IdentityDictionary<A.TreeNode, IScope> ResolveIn = new();
        public readonly IdentityDictionary<A.TreeNode, A.TreeNode> ResolvedTo = new();

        private readonly List<Diagnostic> Diagnostics = new();
        private readonly Queue<A.IResolveable> Resolveables = new();

        public Module()
        {
            Root = new Namespace(this, null, "");
            Name = "::";
        }

        public Namespace Root { get; }
        public string Name { get; }

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
            foreach (var ns in Root.EnumerateChildren())
            {
                if (ns.Entities.Count > 0)
                {
                    writer.WriteLine(ns.GetPath());

                    ns.DumpDeclarations(writer);
                }
            }

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
