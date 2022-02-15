using System;
using Six.Six;

Runner.Run();

Wait();

void Wait()
{
    Console.Write("any key ... ");
    Console.ReadKey(true);
    Console.WriteLine();
}
