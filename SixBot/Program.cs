using Six.Samples;
using SixBot;

//new TParser().Match("tt");
//new EParser().Match("e+e");
//new EParser().Match("e+e+e");
//new EParser().Match("e+e+e+e");
//new EParser().Match("e+e+e+e+e");
//Console.WriteLine();

var which = 5;
var count = 0;
foreach (var sample in Sampler.LoadSix())
{
    var name = Path.GetExtension(Path.GetFileNameWithoutExtension(sample.Name)).Substring(1);
    if (which == count)
    {
        new SixParser().Match(name, sample.Content);
    }
    ++count;
}
Console.WriteLine();

var grammars = new Six.Input.Checker().Run().ToList();

foreach (var grammar in grammars)
{
    if (grammar == null)
    {
        continue;
    }

    Console.WriteLine(grammar.Name);

    var creator = new Six.Gen.Ebnf.EbnfCreator(grammar);
    var transformed = creator.Create();

    using (var writer = Six.Ast.GrammarExtensions.Writer($"{grammar.Name}-ebnf.txt"))
    {
        new Six.Gen.Ebnf.EbnfDumper(transformed).Dump(writer);
    }
}

try
{
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.Write("any key ... ");
Console.ReadKey(true);
