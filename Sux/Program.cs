using Six.Runtime;

var count = 0;
foreach (var file in SourceFile.LoadAll())
{
    count += 1;

    if (IsModule(file) || IsPackage(file))
    {
        Console.WriteLine($"{count,3} {file.Fullname}");
    }
}

Wait();

bool IsModule(SourceFile file)
{
    return string.Compare(file.Name, "module.ceylon", true) == 0;
}

bool IsPackage(SourceFile file)
{
    return string.Compare(file.Name, "package.ceylon", true) == 0;
}



void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}
