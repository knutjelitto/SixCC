using Six.Gen.Ebnf;
using Six.Ast;
using Six.Samples;
using SixBot;

Check<SixParser>(0, Sampler.LoadSix());
Check<TParser>(6, Sampler.LoadT());
Check<EParser>(0, Sampler.LoadE());
Console.WriteLine();

void Check<ParserType>(int which, IEnumerable<Sample> samples)
    where ParserType : ParserCore, new()
{
    if (which == 0)
    {
        return;
    }

    var count = 0;
    foreach (var sample in samples)
    {
        count++;

        var name = Path.GetExtension(Path.GetFileNameWithoutExtension(sample.Name))[1..];
        Console.WriteLine($"{typeof(ParserType).Name,-12} {count} check {name}");
        if (which == count)
        {
            new ParserType().Match(name, sample.Content);
        }
    }
}

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

    var white = transformed.WhitespaceRule;
    new RexTransformer(transformed).Transform();

    using (var writer = $"{grammar.Name}-ebnf.txt".Writer())
    {
        new EbnfDumper(transformed).Dump(writer);
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
