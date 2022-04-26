using Six.Core;
using Six.Core.Errors;
using Six.Six.Instructions;
using Six.Six.Types;
using Six.Six.Wasms;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Module
    {
        public static string Language => "six";
        public static string LanguageCore => "core";
        public static string LanguageMeta => "meta";
        public static string CoreNamespace => $"{Language}.{LanguageCore}";
        public static string MetaNamespace => $"{CoreNamespace}.{LanguageMeta}";
        public static string ModuleCtor => "module@initialize";
        public static string DefaultCtor => "ctor@default";
        public static string InitCtor => "ctor@initialize";
        public static string MetaClassName => $"{MetaNamespace}.Class";
        public static string StringClassName => $"{CoreNamespace}.String";
        public static string ModuleFunctionsTableName => $"{CoreNamespace}.functions";
        public static string DispatchTableName => $"{CoreNamespace}.dispatch";
        public static string DataAndHeapMemory => $"{CoreNamespace}.Data&Heap";
        public static string Data_Start => $"{CoreNamespace}.__data_start";
        public static string Heap_Start => $"{CoreNamespace}.__heap_start";
        public static string Heap_Current => $"{CoreNamespace}.__heap_current";

        public static string Allocator => "alloc";
        public static string ClassAlloc => "classAlloc";
        public static string CoreClassAlloc => $"{CoreNamespace}.{ClassAlloc}";
        public static string CoreAlloc => $"{CoreNamespace}.{Allocator}";

        private readonly List<Diagnostic> Diagnostics = new();

        public Module()
        {
            Root = new NamespaceBlock(new ModuleBlock(this, ""), "");
            Name = CoreNamespace;
            Resolver = new Resolver(this);
            Builtins = new Builtins(this);
            Errors = new Errors(this);
            Validator = new Validator(this);
            Checker = new TypeChecker(this);
        }

        public NamespaceBlock Root { get; }
        public string Name { get; }
        public Resolver Resolver { get; }
        public Builtins Builtins { get; }
        public Errors Errors { get; }
        public Validator Validator { get; }
        public TypeChecker Checker { get; }

        public bool HasErrors => Diagnostics.Count > 0;

        public string Emit()
        {
            Validator.Validate();

            if (!HasErrors)
            {
                var waModule = new WaModule(this, Module.MetaClassName, Module.StringClassName);
                var waWalker = new WaWalker(waModule);

                waWalker.Walk();

                waModule.Prepare();
                waModule.Emit();

                if (!HasErrors)
                {
                    var wat = waModule.Writer.ToString();

                    using (var dumper = $"six.core.wat".Writer())
                    {
                        dumper.Write(wat);
                    }

                    return wat;
                }
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
                    inner = new NamespaceBlock(current, name);
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
            }

            WhenDiagnostics();
        }

        public IEnumerable<NamespaceBlock> GetNamespaces()
        {
            return Root.GetNamespaces();
        }

        public Decl.Classy FindCoreClass(string name)
        {
            var core = GetCoreNamespace();

            var decl = core.TryFind2(name);
            if (decl is Decl.Classy classy)
            {
                return classy;
            }

            Assert(false);
            throw Errors.CanNotResolveInCore("class", name);
        }

        public Decl.Class CoreFindClass(ILocation location, string name)
        {
            var core = GetCoreNamespace();

            return core.Find<Decl.Class>(location, name);
        }

        public NamespaceBlock GetCoreNamespace()
        {
            var language = Root.Get(Language);
            Assert(language != null);
            var core = language.Get(LanguageCore);
            Assert(core != null);

            return core;
        }
    }
}
