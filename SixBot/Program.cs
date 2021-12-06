using Six.Gen.Ebnf;
using Six.Ast;
using Six.Samples;
using Six.Core.Errors;
using SixBot;

Check<SixParser>(1, Sampler.LoadSix());
Check<TParser>(0, Sampler.LoadT());
Check<EParser>(0, Sampler.LoadE());
Check<ErrorParser>(0, Sampler.LoadError());
//CheckJson(Sampler.LoadJson());
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

        Console.WriteLine($"{typeof(ParserType).Name,-12} {count} check {sample.Name}");
        if (which == count || true)
        {
            for (var i = 0; i < 0; ++i)
            {
                if (!new ParserType().Recognize(sample.Name, sample.Content))
                {
                    new ParserType().Match(sample.Name, sample.Content);
                    return;
                }
            }
            new ParserType().Match(sample.Name, sample.Content);
        }
    }
}

#pragma warning disable CS8321 // Local function is declared but never used
void CheckJson(IEnumerable<Sample> samples)
{
    var count = 0;
    foreach (var sample in samples)
    {
        count++;

        Console.Write($"JSON {count,3} check - ");
        var parser = new JsonParser();
        bool fail;
        bool ok;
        if (ok = parser.Recognize(sample.Name, sample.Content))
        {
            fail = sample.Name.StartsWith("n_");
            Outcome();
        }
        else
        {
            fail = sample.Name.StartsWith("y_");
            Outcome();
        }
        Console.WriteLine(sample.Name);

        if (fail)
        {
            break;
        }

        void Outcome()
        {
            if (!sample.Name.StartsWith("i_"))
            {
                ok = sample.Name.StartsWith("y_") && ok || sample.Name.StartsWith("n_") && !ok;
            }
            Console.Write(ok ? "OK   " : "FAIL ");
        }
    }
}
#pragma warning restore CS8321 // Local function is declared but never used

try
{
    foreach (var sample in Sampler.LoadSix())
    {
        if (!sample.Name.Contains("Six.six") && false)
        {
            continue;
        }

        Console.WriteLine(sample.Name);

        var ast = Six.Input.Builder.Build(sample.Name, sample.Content);
        var ebnf = new Six.Gen.Ebnf.EbnfCreator(ast).Create();

        using (var writer = $"{ast.Name}-ebnf.txt".Writer())
        {
            new EbnfDumper(ebnf).Dump(writer);
        }
    }

}
catch (DiagnosticException ex)
{
    Console.WriteLine("=== errors ===");
    ex.Report();
}

Console.Write("any key ... ");
Console.ReadKey(true);
