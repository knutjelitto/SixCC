using Six.Ceylon;

var modules = CeylonLoader.GetModules().OrderBy(m => m.Name).ToList();

var compiler = new CeylonCompiler(withIndex: false);

try
{
    foreach (var module in modules)
    {
        if (!compiler.BuildModule(module))
        {
            break;
        }
    }
}
catch { }

compiler.Report();

Wait();

void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}
