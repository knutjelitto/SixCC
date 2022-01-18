using Six.Ceylon;

#pragma warning disable CS8321 // Local function is declared but never used

var modules = Loader.GetModules().ToList();

//DumpModules(modules);

var compiler = new Compiler();
compiler.BuildModule(modules.Where(m => m.Name == "language").First());

Wait();

void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}

void DumpModules(List<Module> modules)
{
    foreach (var module in modules)
    {
        Console.WriteLine($"module: {module.Name}");
        foreach (var package in module.Packages.OrderBy(p => p.Name))
        {
            Console.Write($"    {package.Name}");
            var length = int.MaxValue;
            foreach (var file in package.Files)
            {
                if (length > 120)
                {
                    Console.WriteLine();
                    Console.Write("        ");
                    length = 0;
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write($"{file.BaseName}");
                length += file.BaseName.Length + 1;
            }
            Console.WriteLine();
        }
    }
}
