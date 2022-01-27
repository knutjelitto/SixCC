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
        private readonly CeylonVisitor visitor;

        public CeylonCompiler(CompilerConfiguration configuration)
        {
            if (configuration.WithRuleIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }

            this.configuration = configuration;

            world = new World();
            visitor = new CeylonVisitor(world);
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

            using (var writer = $"{parser.__Name}-Namespaces.txt".Writer())
            {
                world.Global.Dump(writer);
            }
        }

        public bool BuildModule(Module module)
        {
            Console.Write($"{module.Name,-28}");

            using (world.Use(module))
            {
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
        }

        public bool BuildPackage(Package package)
        {
            Console.Write($"  {package.Name[(package.Name.IndexOf('.') + 1)..],-26}");

            using (world.Use(package))
            {
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
        }

        private bool HandleFile(SourceFile file)
        {
            var ok = BuildFile(file);

            if (ok)
            {
                if (configuration.BuildAst)
                {
                    visitor.Walk(file);
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

        private static CXStart? GetStart(SourceFile file)
        {
            return file.Tree as CXStart;
        }

        private static CModuleDescriptor? GetModuleDescriptor(SourceFile file)
        {
            return GetStart(file)?.CompilationUnit as CModuleDescriptor;
        }

        private static CPackageDescriptor? GetPackageDescriptor(SourceFile file)
        {
            return GetStart(file)?.CompilationUnit as CPackageDescriptor;
        }
    }
}
