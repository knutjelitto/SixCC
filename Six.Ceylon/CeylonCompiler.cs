using Six.Ceylon.Ast;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class CeylonCompiler : Compiler<CeylonParser>
    {
        private readonly CompilerConfiguration configuration;
        private readonly World world;

        public CeylonCompiler(CompilerConfiguration configuration)
        {
            if (configuration.WithRuleIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }

            this.configuration = configuration;

            world = new World();
        }

        public void Report()
        {
            if (ruleIndex != null)
            {
                using (var writer = $"{parser.__Name}-RulesIndex.txt".Writer())
{
                    ruleIndex.Dump(writer);
                }
            }
        }

        public bool BuildModule(Module module)
        {
            Console.Write($"{module.Name,-28}");

            var ok = HandleFile(module.ModuleFile);

            Console.WriteLine();

            if (ok)
            {
                _ = GetModuleDescriptor(module.ModuleFile);

                foreach (var package in module.Packages)
                {
                    ok = ok && BuildPackage(package);

                    if (!ok)
                    {
                        break;
                    }
                }
            }

            return ok;
        }

        public bool BuildPackage(Package package)
        {
            Console.Write($"  {package.Name[(package.Name.IndexOf('.') + 1)..],-26}");

            var ok = true;

            if (package.PackageFile != null)
            {
                ok = HandleFile(package.PackageFile);

                if (ok)
                {
                    var packageDescriptor = GetPackageDescriptor(package.PackageFile);
                }
            }

            if (ok)
            {
                foreach (var file in package.Files)
                {
                    ok = ok && HandleFile(file);

                    if (!ok)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine();

            return ok;
        }

        private bool HandleFile(FileJob file)
        {
            var ok = BuildFile(file);

            if (ok)
            {
                if (file.Tree != null)
                {
                    var visitor = new CeylonVisitor(world);
                    visitor.Walk(file.Tree);
                }

                if (configuration.DumpSppf && file.Sppf != null)
                {
                    using (var writer = $"{file.ShortPath}.sppf".Writer())
                    {
                        SppfDumper.Dump(file.Sppf, writer);
                    }
                }
                if (configuration.DumpTree && file.Tree != null)
                {
                    using (var writer = $"{file.ShortPath}.tree".Writer())
                    {
                        TypedDumper.Dump(file.Tree, writer);
                    }
                }
            }

            return ok;
        }

        private static CXStart? GetStart(FileJob file)
        {
            return file.Tree as CXStart;
        }

        private static CModuleDescriptor? GetModuleDescriptor(FileJob file)
        {
            return GetStart(file)?.CompilationUnit as CModuleDescriptor;
        }

        private static CPackageDescriptor? GetPackageDescriptor(FileJob file)
        {
            return GetStart(file)?.CompilationUnit as CPackageDescriptor;
        }
    }
}
