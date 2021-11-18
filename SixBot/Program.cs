using SixBot;

new Six.Input.Checker().Run();

new EParser().Print();

try
{
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.Write("any key ... ");
Console.ReadKey(true);
