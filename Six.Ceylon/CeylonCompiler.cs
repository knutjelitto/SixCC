using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
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
                if (file.Sppf != null)
                {
                    using (var writer = $"{file.ShortPath}.sppf".Writer())
                    {
                        SppfDumper.Dump(file.Sppf, writer);
                    }
                }
                if (file.Tree != null)
                {
                    using (var writer = $"{file.ShortPath}.tree".Writer())
                    {
                        TypedDumper.Dump(file.Tree, writer);
                    }

                    declarationVisitor.Walk(file.Tree);
                }
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
