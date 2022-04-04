using System;
using Six.Six;

var ok = Runner.Run();

if (!ok)
{
    Wait();
}

void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}
