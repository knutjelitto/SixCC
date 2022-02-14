using Six.Core;
using Six.Core.Errors;

using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public class Module : Container
    {
        private static readonly string Language = "sax";
        private static readonly string Core = "core";
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

        public void DumpEntities()
        {
            foreach (var ns in GetNamespaces())
            {
                var path = ns.GetPath().Replace(".", "/");
                foreach (var top in ns.Children)
                {
                    if (top is Named named)
                    {
                        var name = $"entities/{path}/{named.Name}.txt";
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
            DumpReferences(writer);
        }

        private void DumpReferences(Writer writer)
        {
            foreach (var declaration in GetNamespaces().SelectMany(ns => ns.Children).OrderBy(e => e.Name))
            {
                var attrs = new StringBuilder();
                attrs.Append(declaration.IsShared ? "S" : " ");
                attrs.Append(declaration.IsNative ? "N" : " ");

                writer.WriteLine($"{declaration.GetKind(),-12} [{attrs}] {declaration.GetName(),-30} {declaration.GetLocation()}");
            }
        }

        public Declaration? Resolve(string name)
        {
            return null;
        }

        public Entity? CoreFind(string name)
        {
            var language = Root.Get(Language);
            if (language != null)
            {
                var core = language.Get(Core);
                if (core != null)
                {
                    return core.Find(name);
                }
            }
            return null;
        }

        public Entity? CoreFindNull()
        {
            return CoreFind(CoreNull);
        }

        public Entity? CoreFindIterable()
        {
            return CoreFind(CoreIterable);
        }

        public Entity? CoreFindCallable()
        {
            return CoreFind(CoreCallable);
        }

        public Entity? CoreFindTuple()
        {
            return CoreFind(CoreTuple);
        }

        public Entity? CoreFindEmpty()
        {
            return CoreFind(CoreEmpty);
        }

        public Entity? CoreFindSequential()
        {
            return CoreFind(CoreSequential);
        }

        public Entity? CoreFindSequence()
        {
            return CoreFind(CoreSequence);
        }

        public Entity? CoreFindNothing()
        {
            return CoreFind(CoreNothing);
        }
    }
}
