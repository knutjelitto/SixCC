using Six.Core;
using Six.Core.Errors;
using Six.Runtime.Types;
using System;
using System.IO;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Module : Container
    {
        private static readonly string Language = "six";
        public static readonly string UInt64 = "u64";
        public static readonly string Int64 = "i64";
        public static readonly string UInt32 = "u32";
        public static readonly string Int32 = "i32";
        public static readonly string UInt16 = "u16";
        public static readonly string Int16 = "u16";
        public static readonly string UInt8 = "u8";
        public static readonly string Int8 = "i8";
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

        public T AddChild<T>(T entity) where T: Entity
        {
            throw new InvalidOperationException();
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
                foreach (var top in ns.GetDeclarations())
                {
                    var idx = 0;
                    if (top.Count > 1)
                    {
                        idx = 1;
                    }
                    foreach (var declaration in top)
                    {
                        var subst = declaration.Name.Text
                            .Replace("!", "@not@")
                            .Replace("|", "@or@")
                            .Replace("&", "@and@")
                            .Replace("^", "@xor@")
                            .Replace("+", "@add@")
                            .Replace("-", "@sub@")
                            .Replace("*", "@mul@")
                            .Replace("/", "@div@")
                            .Replace("%", "@rem@")
                            ;

                        if (idx > 0)
                        {
                            subst = $"{subst}-{idx}";
                            idx += 1;
                        }

                        var invalid = Path.GetInvalidFileNameChars();
                        Assert(!subst.Any(c => invalid.Contains(c)));

                        var name = $"entities/{path}/{subst}.txt";
                        using (var writer = name.Writer())
                        {
                            new SemaDumper(writer).DumpEntity(declaration);
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
        }

        private void DumpDeclarations(Writer writer)
        {
            var count = 0;
            foreach (var declaration in GetNamespaces().SelectMany(ns => ns.GetDeclarationsFlat()).OrderBy(e => e.Name))
            {
                count += 1;

                var attrs = new StringBuilder();
                attrs.Append(declaration.IsShared ? "S" : " ");
                attrs.Append(declaration.IsNative ? "N" : " ");

                writer.WriteLine($"{count,3} {declaration.GetKind(),-12} [{attrs}] {declaration.GetName(),-30} {declaration.GetLocation()}");
            }
        }

        public Declarations Resolve(A.Reference reference)
        {
            Assert(false);
            throw new InvalidOperationException();
        }

        public Declarations Resolve(RLiteral literal)
        {
            Assert(false);
            throw new InvalidOperationException();
        }

        public Declarations CoreFind(A.TreeNode usage, string name)
        {
            var language = Root.Get(Language);
            Assert(language != null);
            return language.Find(usage, name);
        }

        public Declarations CoreFindNull(A.TreeNode usage)
        {
            return CoreFind(usage, CoreNull);
        }

        public Declarations CoreFindIterable(A.TreeNode usage)
        {
            return CoreFind(usage, CoreIterable);
        }

        public Declarations CoreFindCallable(A.TreeNode usage)
        {
            return CoreFind(usage, CoreCallable);
        }

        public Declarations CoreFindTuple(A.TreeNode usage)
        {
            return CoreFind(usage, CoreTuple);
        }

        public Declarations CoreFindEmpty(A.TreeNode usage)
        {
            return CoreFind(usage, CoreEmpty);
        }

        public Declarations CoreFindSequential(A.TreeNode usage)
        {
            return CoreFind(usage, CoreSequential);
        }

        public Declarations CoreFindSequence(A.TreeNode usage)
        {
            return CoreFind(usage, CoreSequence);
        }

        public Declarations CoreFindNothing(A.TreeNode usage)
        {
            return CoreFind(usage, CoreNothing);
        }
    }
}
