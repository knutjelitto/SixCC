using Six.Core;
using Six.Core.Errors;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Module : Container
    {
        private static readonly string Language = "six";
        public static readonly string CoreNull = "Null";
        public static readonly string CoreNothing = "Nothing";
        public static readonly string CoreIterable = "Iterable";
        public static readonly string CoreCallable = "Callable";
        public static readonly string CoreSequence = "Sequence";
        public static readonly string CoreSequential = "Sequential";
        public static readonly string CoreTuple = "Tuple";
        public static readonly string CoreEmpty = "Empty";

        private readonly List<Diagnostic> Diagnostics = new();

        public Module()
        {
            Root = new Namespace("", this);
            Name = "::";
            Resolver = new Resolver(this);
        }

        public Namespace Root { get; }
        public string Name { get; }
        public Container Parent => this;
        Module Container.Module => this;
        public Resolver Resolver { get; }

        public IReadOnlyList<Entity> Children => Enumerable.Empty<Entity>().ToList();

        public Entity AddChild(Entity entity)
        {
            throw new System.InvalidOperationException();
        }

        public Container Open(A.NamespaceIntro @namespace)
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

        public void DumpEntities()
        {
            foreach (var ns in GetNamespaces())
            {
                var path = ns.GetPath().Replace(".", "/");
                foreach (var top in ns.Children)
                {
                    if (top is Declaration named)
                    {
                        var subst = named.Name
                            .Replace("|", "@or@")
                            .Replace("+", "@plus@")
                            ;

                        var name = $"entities/{path}/{subst}.txt";
                        using (var writer = name.Writer())
                        {
                            new SemaDumper(writer).DumpEntity(named);
                        }
                    }
                }
            }
        }

        public void Dump(Writer writer)
        {
            if (Diagnostics.Count > 0)
            {
                writer.WriteLine("========== ERROR");
                foreach (var diagnostic in Diagnostics)
                {
                    diagnostic.Report(writer);
                }
                writer.WriteLine();
            }

            writer.WriteLine("========== DEFINED");
            DumpDeclarations(writer);

            writer.WriteLine();
            writer.WriteLine("========== UNDEFINED");
        }

        private void DumpDeclarations(Writer writer)
        {
            var count = 0;
            foreach (var declaration in GetNamespaces().SelectMany(ns => ns.GetDeclarations()).OrderBy(e => e.Name))
            {
                count += 1;

                var attrs = new StringBuilder();
                attrs.Append(declaration.IsShared ? "S" : " ");
                attrs.Append(declaration.IsNative ? "N" : " ");

                writer.WriteLine($"{count,3} {declaration.GetKind(),-12} [{attrs}] {declaration.GetName(),-30} {declaration.GetLocation()}");
            }
        }

        public Declarations Resolve(string name)
        {
            Assert(false);
            throw new System.InvalidOperationException();
        }

        public Declarations CoreFind(string name)
        {
            var language = Root.Get(Language);
            Assert(language != null);
            return language.Find(name);
        }

        public Declarations CoreFindNull()
        {
            return CoreFind(CoreNull);
        }

        public Declarations CoreFindIterable()
        {
            return CoreFind(CoreIterable);
        }

        public Declarations CoreFindCallable()
        {
            return CoreFind(CoreCallable);
        }

        public Declarations CoreFindTuple()
        {
            return CoreFind(CoreTuple);
        }

        public Declarations CoreFindEmpty()
        {
            return CoreFind(CoreEmpty);
        }

        public Declarations CoreFindSequential()
        {
            return CoreFind(CoreSequential);
        }

        public Declarations CoreFindSequence()
        {
            return CoreFind(CoreSequence);
        }

        public Declarations CoreFindNothing()
        {
            return CoreFind(CoreNothing);
        }
    }
}
