using Six.Runtime;

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
                foreach (var package in module.Packages)
                {
                    ok = ok && BuildPackage(package);

                    if (!ok)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine();
        }

        public bool BuildPackage(Package package)
        {
            Console.Write($"  {package.Name,-26}");
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

        public bool BuildFile(SourceFile file)
        {
            var ok = Ok(() => Parse(file));

            if (!ok)
            {
                Console.WriteLine();
                Console.WriteLine($"{file.Fullname}");
            }

            return ok;
        }

        private bool Parse(SourceFile file)
        {
            var source = Source.FromString(file.Fullname, file.Content);
            parser.Reset();
            return parser.Parse(source);
        }

        private bool Ok(Func<bool> action)
        {
            Console.Write("?");

            var ok = action();

            if (ok)
            {
                Console.Write("\b|");
            }
            else
            {
                Console.Write("\b×");
            }

            return ok;
        }
    }
}
