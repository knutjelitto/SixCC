using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class CeylonCompiler : Compiler<CeylonParser>
    {
        private readonly CeylonVisitor declarationVisitor = new CeylonVisitor();

        public CeylonCompiler(bool withIndex = false)
        {
            if (withIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }
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

        public bool BuildModule(ModuleContainer module)
        {
            Console.Write($"{module.Name,-28}");

            var ok = HandleFile(module.ModuleFile);

            Console.WriteLine();

            if (ok)
            {
                var moduleDescriptor = GetModuleDescriptor(module.ModuleFile);

                var name = moduleDescriptor?.ModuleName.ToString() ?? module.Name;

                Assert(name == module.Name);

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

        public bool BuildPackage(PackageContainer package)
        {
            Console.Write($"  {package.Name[(package.Name.IndexOf('.') + 1)..],-26}");

            var ok = true;

            if (package.PackageFile != null)
            {
                ok = HandleFile(package.PackageFile);

                if (ok)
                {
                    var packageDescriptor = GetPackageDescriptor(package.PackageFile);

                    var name = packageDescriptor?.PackagePath.ToString() ?? package.Name;

                    Assert(name == package.Name);
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

            if (ok && file.Tree != null)
            {
                declarationVisitor.Walk(file.Tree);
            }

            return ok;
        }

        private CXStart? GetStart(FileJob file)
        {
            return file.Tree as CXStart;
        }

        private CModuleDescriptor? GetModuleDescriptor(FileJob file)
        {
            return GetStart(file)?.CompilationUnit as CModuleDescriptor;
        }

        private CPackageDescriptor? GetPackageDescriptor(FileJob file)
        {
            return GetStart(file)?.CompilationUnit as CPackageDescriptor;
        }
    }
}
