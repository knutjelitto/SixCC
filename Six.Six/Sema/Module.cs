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
        public static readonly string InitCtor = "ctor@initialize";
        public static string ModuleFunctions => $"{CoreNamespace}.functions";
        public static string VTableFunctions => $"{CoreNamespace}.dispatch";
        public static string DataAndHeap => $"{CoreNamespace}.Data&Heap";
        public static string Data_Start => $"{CoreNamespace}.__data_start";
        public static string Heap_Start => $"{CoreNamespace}.__heap_start";
        public static string Heap_Current => $"{CoreNamespace}.__heap_current";

        public static readonly string Allocator = "alloc";
        public static readonly string ClassAlloc = "classAlloc";
        public static string CoreClassAlloc => $"{CoreNamespace}.{ClassAlloc}";
        public static string CoreAlloc => $"{CoreNamespace}.{Allocator}";

        private readonly List<Diagnostic> Diagnostics = new();

        public Module()
        {
            Root = new NamespaceBlock("", new ModuleBlock(this, ""));
            Name = "six";
            Resolver = new Resolver(this);
            Builtins = new Builtins.Builtins(this);
            Errors = new Errors(this);
            Emitter = new Emitter(this, new Writer());
            Validator = new Validator(this);
            Checker = new TypeChecker(this);
        }

        public NamespaceBlock Root { get; }
        public string Name { get; }
        public Resolver Resolver { get; }
        public Builtins.Builtins Builtins { get; }
        public Errors Errors { get; }
        public Emitter Emitter { get; }
        public Validator Validator { get; }
        public TypeChecker Checker { get; }

        public bool HasErrors => Diagnostics.Count > 0;

        public string Emit()
        {
            Validator.Validate();
            Emitter.EmitModule();

            if (!HasErrors)
            {
                var wat = Emitter.Writer.ToString();

                using (var dumper = $"six.core.wat".Writer())
                {
                    dumper.Write(wat);
                }

                return wat;
            }

            return "";
        }

        public NamespaceBlock OpenNamespace(A.NamespaceIntro nsIntro)
        {
            var current = Root;
            foreach (var name in nsIntro.Names.Select(n => n.Text))
            {
                if (!current.Children.TryGetValue(name, out var inner))
                {
                    inner = new NamespaceBlock(name, current);
                    current.Children.Add(name, inner);
                }
                current = inner;
            }
            return current;
        }

        public void Add(Diagnostic diagnostic)
        {
            Diagnostics.Add(diagnostic);
        }

        public void Add(DiagnosticException error)
        {
            foreach (var diagnostic in error.Diagnostics)
            {
                Add(diagnostic);
            }
        }

        private void WhenDiagnostics()
        {
            if (Diagnostics.Count > 0)
            {
                throw new DiagnosticException(Diagnostics.ToArray());
            }
        }

        public void WriteErrors()
        {
            using (var writer = $"six.core.errors.txt".Writer())
            {
                foreach (var diagnostic in Diagnostics)
                {
                    diagnostic.Report(writer);
                }
                writer.WriteLine();
            }

            WhenDiagnostics();
        }

        public void Dump(Writer writer)
        {
            DumpDeclarations(writer);
        }

        public IEnumerable<NamespaceBlock> GetNamespaces()
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

        public Type.ClassyReference CoreFindType(string name)
        {
            var core = GetCoreNamespace();

            var decl = core.Content.TryFind(name);
            if (decl is Decl.Classy classy)
            {
                var reference = classy.Type as Type.ClassyReference;
                Assert(reference != null);
                return reference;
            }

            Assert(false);
            throw Errors.CantResolveInCore("class", name);
        }

        public Decl.Class CoreFindClass(A.TreeNode tree, string name)
        {
            var core = GetCoreNamespace();

            var decl = core.Content.Find(tree, name);
            Assert(decl is Decl.Class);
            return (Decl.Class)decl;
        }

        public Decl.Function CoreFindFunction(string name)
        {
            var core = GetCoreNamespace();

            var decl = core.Content.TryFind(name);
            if (decl is Decl.Function function)
            {
                return function;
            }

            Assert(false);
            throw Errors.CantResolveInCore("function", name);
        }

        public NamespaceBlock GetCoreNamespace()
        {
            var language = Root.Get(Language);
            Assert(language != null);
            var core = language.Get(LanguageCore);
            Assert(core != null);
            Assert(core is NamespaceBlock);

            return (NamespaceBlock)core;
        }

        Scope Scope.Parent => this;
        Module Scope.Module => this;
        T Scope.Declare<T>(T decl, string? name) => throw new NotImplementedException();
        Decl Scope.Resolve(A.TreeNode tree, string name) => throw new NotImplementedException();
        
        //Decl Scope.Find(A.TreeNode tree, string name) => throw new NotImplementedException();
    }
}
