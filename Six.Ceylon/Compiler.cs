using Six.Runtime;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonParserAst;

namespace Six.Ceylon
{
    public class Compiler
    {
        private readonly Parser parser = new CeylonParser();

        public void BuildModule(Module module)
        {
            Console.Write($"{module.Name, -28}");

            var ok = BuildFile(module.ModuleFile);

            Console.WriteLine();

            if (ok)
            {
                var moduleDescriptor = GetModuleDescriptor(module.ModuleFile);

                var name = moduleDescriptor.ModuleName.ToString();

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

        public bool BuildFile(FileJob job)
        {
            var ok = Ok(() => Parse(job));

            if (!ok)
            {
                Console.WriteLine($"parse: {job.Fullname}");

                return false;
            }

            var sppf = SppfBuilder.Build(job.Source, parser);

            if (sppf == null)
            {
                Console.WriteLine($"sppf: {job.Fullname}");

                return false;
            }

            job.Tree = TypedBuilder.Build(sppf);

            return true;
        }

        private bool Parse(FileJob job)
        {
            var source = Source.FromString(job.Fullname, job.Content);
            parser.Reset();
            return parser.Parse(source);
        }

        private bool Ok(Func<bool> action)
        {
            Console.Write("?");

            var ok = action();

            if (ok)
            {
                Console.Write("\b.");
            }
            else
            {
                Console.Write("\b×");
            }

            return ok;
        }

        private CXStart GetStart(FileJob file)
        {
            return (CXStart)file.Tree!;
        }

        private CModuleDescriptor GetModuleDescriptor(FileJob file)
        {
            return (CModuleDescriptor)GetStart(file).CompilationUnit;
        }
    }
}
