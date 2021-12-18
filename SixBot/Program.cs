﻿using Six.Gen.Ebnf;
using Six.Samples;
using Six.Core.Errors;
using SixBot;
using Six.Gen;
using Six.Runtime.Sppf;
using Six.Runtime.Tree;

Check<TestParser>(0, true, Sampler.LoadTest());
Check<AParser>(0, true, Sampler.LoadA());
Check<BParser>(0, true, Sampler.LoadB());
Check<CParser>(0, true, Sampler.LoadC());
Check<DParser>(0, true, Sampler.LoadD());
Check<SixParser>(-1, true, Sampler.LoadSix());
CheckJson(false, Sampler.LoadJson());
CheckGenerate(true);
Console.Write("any key ... ");
Console.ReadKey(true);

void Check<ParserType>(int which, bool parse, IEnumerable<Sample> samples)
    where ParserType : ParserCore, new()
{
    if (which == 0)
    {
        return;
    }

    var watch = new Stopwatch();
    watch.Start();
    var count = 0;
    foreach (var sample in samples)
    {
        count++;

        var content = (sample.Content.Length < 20 ? sample.Content : sample.Content[..20] + " ...").Esc();
        Console.WriteLine($"{typeof(ParserType).Name,-12} {count} check {sample.Name} {content}");
        if (which == -1 || which == count)
        {
            var source = Source.FromString(sample.Name, sample.Content);

            if (parse)
            {
                var parser = new ParserType();
                var ok = parser.Parse(source);
                if (ok)
                {
                    var builder = new SppfBuilder(source, parser);
                    var root = builder.BuildSppf();
                    if (root != null)
                    {
                        var file = Path.GetFileNameWithoutExtension(source.Name);
                        using (var writer = $"{parser.__Name}-{file}-sppf.txt".Writer())
                        {
                            new SppfDumper(root, writer).Dump();
                        }
                        using (var writer = $"{parser.__Name}-{file}-enum.txt".Writer())
                        {
                            new SppfEnumerator(root, writer).Enum();
                        }
                        var treeBuilder = new TreeBuilder(root);
                        var tree = treeBuilder.Build();
                        using (var writer = $"{parser.__Name}-{file}-tree.txt".Writer(2))
                        {
                            new TreeDumper(tree, writer).Dump();
                        }
                    }
                }
            }
            else
            {
                new ParserType().Match(source);
            }
        }
    }
    watch.Stop();
    Console.WriteLine();
    Console.WriteLine($"elapsed: {Math.Round(watch.Elapsed.TotalMilliseconds)} ms");
}

void CheckJson(bool enabled, IEnumerable<Sample> samples)
{
    if (!enabled)
    {
        return;
    }

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

void CheckGenerate(bool enabled)
{
    if (!enabled)
    {
        return;
    }
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

            using (var writer = $"{ebnf.Name}-ebnf.txt".Writer())
            {
                new EbnfDumper(ebnf).Dump(writer);
            }

            using (var generator = new EbnfCsGenerator())
            {
                generator.Generate(ebnf.Name, sample.Content);
                var generated = generator.ToString();

                using (var writer = $"{ebnf.Name}.gen.cs".Writer())
                {
                    writer.Write(generated);
                }
            }
        }

    }
    catch (DiagnosticException ex)
    {
        Console.WriteLine("=== errors ===");
        ex.Report();
    }
}
