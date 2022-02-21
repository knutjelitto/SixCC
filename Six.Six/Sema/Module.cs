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
        public static readonly string DefaultCtor = "@dctor";
        private static readonly string Language = "six";

        public static class Core
        {
            public static readonly string UInt64 = "u64";
            public static readonly string Int64 = "i64";
            public static readonly string UInt32 = "u32";
            public static readonly string Int32 = "i32";
            public static readonly string UInt16 = "u16";
            public static readonly string Int16 = "u16";
            public static readonly string UInt8 = "u8";
            public static readonly string Int8 = "i8";
            public static readonly string Null = "Null";
            public static readonly string Nothing = "Nothing";
            public static readonly string Anything = "Anything";
            public static readonly string Iterable = "Iterable";
            public static readonly string Callable = "Callable";
            public static readonly string Sequence = "Sequence";
            public static readonly string Sequential = "Sequential";
            public static readonly string Tuple = "Tuple";
            public static readonly string Empty = "Empty";
        }


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

        public IReadOnlyList<A.TreeNode> Children => Enumerable.Empty<A.TreeNode>().ToList();

        public T AddChild<T>(T node) where T: A.TreeNode
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
                foreach (var declaration in ns.GetDeclarations())
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

                    var invalid = Path.GetInvalidFileNameChars();
                    Assert(!subst.Any(c => invalid.Contains(c)));

                    var name = $"entities/{path}/{subst}.txt";
                    using (var writer = name.Writer())
                    {
                        new SemaDumper(writer, Resolver).DumpEntity(declaration);
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
            foreach (var declaration in GetNamespaces().SelectMany(ns => ns.GetDeclarations()).OrderBy(e => e.Name))
            {
                count += 1;

                var attrs = new StringBuilder();
                attrs.Append(declaration.IsShared() ? "S" : " ");
                attrs.Append(declaration.IsNative() ? "N" : " ");

                writer.WriteLine($"{count,3} {declaration.GetKind(),-12} [{attrs}] {declaration.GetName(),-30} {declaration.GetLocation()}");
            }
        }

        public A.Decl Resolve(A.Reference reference)
        {
            Assert(false);
            throw new InvalidOperationException();
        }

        public A.Decl Resolve(RLiteral literal)
        {
            Assert(false);
            throw new InvalidOperationException();
        }

        public A.Decl? CoreFind(string name)
        {
            var language = Root.Get(Language);
            Assert(language != null);
            return language.Find(name);
        }
    }
}
