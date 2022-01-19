using Six.Runtime;
using static Six.Ceylon.CeylonParserAst;

namespace Six.Ceylon
{
    public class CeylonCompiler : Compiler<CeylonParser>
    {

        public void BuildModule(Module module)
        {
            Console.Write($"{module.Name,-28}");

            var ok = BuildFile(module.ModuleFile);

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
        }

        public bool BuildPackage(Package package)
        {
            Console.Write($"  {package.Name[(package.Name.IndexOf('.') + 1)..],-26}");
            var ok = BuildFile(package.PackageFile);

            if (ok)
            {
                foreach (var file in package.Files)
                {
                    ok = ok && BuildFile(file);

                    if (!ok)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine();

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
    }
}
