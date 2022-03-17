using Six.Core;
using Six.Core.Errors;
using Six.Six.Instructions;
using System;
using System.IO;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Module : Scope
    {
        public static readonly string Language = "six";
        public static readonly string LanguageCore = "core";
        public static readonly string CoreNamespace = $"{Language}.{LanguageCore}";
        public static readonly string DefaultCtor = "ctor@default";
        public static string DataAndHeap => $"{CoreNamespace}.Data&Heap";
        public static string Allocator => $"allocate";

        private readonly List<Diagnostic> Diagnostics = new();

        public Module()
        {
            Root = new Namespace("", this);
            Name = "six";
            Resolver = new Resolver(this);
            Builtins = new Builtins.Builtins(this);
            Errors = new Errors(this);
        }

        public Namespace Root { get; }
        public string Name { get; }
        public Resolver Resolver { get; }
        public Builtins.Builtins Builtins { get; }
        public Errors Errors { get; }

        public bool HasErrors => Diagnostics.Count > 0;

        public string Emit()
        {
            using (var writer = new Writer())
            {
                var emitter = new Emitter(this, writer);
                emitter.EmitModule();

                return writer.ToString();
            }
        }

        public Scope Open(A.NamespaceIntro @namespace)
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

        public void WhenDiagnostics()
        {
            if (Diagnostics.Count > 0)
            {
                throw new DiagnosticException(Diagnostics.ToArray());
            }
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
                    var decl = declaration.ADecl.GetType().Name.ToLowerInvariant();

                    var watName = $"wat/{path}/{decl}/{subst}.wat";
                    using (var writer = watName.Writer())
                    {
                        new Emitter(this, writer).Emit(declaration);
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

        public IEnumerable<Namespace> GetNamespaces()
        {
            return Root.GetNamespaces();
        }

        private void DumpDeclarations(Writer writer)
        {
            var count = 0;
            foreach (var declaration in GetNamespaces().SelectMany(ns => ns.GetDeclarations()).OrderBy(e => e.Name))
            {
                count += 1;

                var attrs = new StringBuilder();
                attrs.Append(declaration.IsShared ? "P" : " ");
                attrs.Append(declaration.IsStatic ? "S" : " ");
                attrs.Append(declaration.IsNative ? "N" : " ");

                writer.WriteLine($"{count,3} {declaration.ADecl.GetKind(),-12} [{attrs}] {declaration.ADecl.GetName(),-30} {declaration.ADecl.GetLocation()}");
            }
        }

        public Type CoreFindType(A.TreeNode tree, string name)
        {
            var core = GetCoreNamespace();

            var decl = core.Find(tree, name);
            Assert(decl is Decl.Classy);
            var classy = decl as Decl.Classy;
            Assert(classy != null);
            var reference = classy.Type as Type.Reference;
            Assert(reference != null);
            return reference;
        }

        public Decl.Class CoreFindClass(A.TreeNode tree, string name)
        {
            var core = GetCoreNamespace();

            var decl = core.Find(tree, name);
            Assert(decl is Decl.Class);
            return (Decl.Class)decl;
        }

        public Decl.Function CoreFindFunction(string name)
        {
            var core = GetCoreNamespace();

            var decl = core.TryFind(name);
            if (decl is Decl.Function function)
            {
                return function;
            }

            Assert(false);
            throw Errors.CantResolveInCore("function", name);
        }

        public Namespace GetCoreNamespace()
        {
            var language = Root.Get(Language);
            Assert(language != null);
            var core = language.Get(LanguageCore);
            Assert(core != null);
            Assert(core is Namespace);

            return (Namespace)core;
        }

        Scope Scope.Parent => this;
        Module Scope.Module => this;
        T Scope.Declare<T>(T decl, string? name) => throw new NotImplementedException();
        Decl Scope.Resolve(A.TreeNode tree, string name) => throw new NotImplementedException();
        Decl Scope.Find(A.TreeNode tree, string name) => throw new NotImplementedException();
        string Scope.FullName => "";
    }
}
