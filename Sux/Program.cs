using Six.Ceylon;

var modules = CeylonLoader.GetModules().OrderBy(m => m.Name).ToList();

var compiler = new CeylonCompiler();
foreach (var module in modules)
{
    compiler.BuildModule(module);
}

Wait();

void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}
