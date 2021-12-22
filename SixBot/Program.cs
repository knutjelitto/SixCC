using Six.Gen.Ebnf;
using Six.Samples;
using Six.Core.Errors;
using SixBot;
using Six.Gen;
using Six.Runtime.Sppf;
using Six.Runtime.Tree;

CheckAllT(0);
Check<T1Parser>(0, Sampler.Load(".t1"));
Check<T2Parser>(0, Sampler.Load(".t2"));
Check<T3Parser>(0, Sampler.Load(".t3"));
Check<T4Parser>(0, Sampler.Load(".t4"));
Check<T5Parser>(0, Sampler.Load(".t5"));
Check<T6Parser>(0, Sampler.Load(".t6"));
Check<T7Parser>(0, Sampler.Load(".t7"));
Check<T8Parser>(0, Sampler.Load(".t8"));
Check<CeylonParser>(25, Sampler.Load(".ceylon"));
Check<SixParser>(0, Sampler.LoadSix());
CheckJson(false, Sampler.LoadJson());
CheckGenerate(true);
Console.Write("any key ... ");
Console.ReadKey(true);

void CheckAllT(int which)
{
    if (which != 0)
    {
        Check<T1Parser>(which, Sampler.Load(".t1"));
        Check<T2Parser>(which, Sampler.Load(".t2"));
        Check<T3Parser>(which, Sampler.Load(".t3"));
        Check<T4Parser>(which, Sampler.Load(".t4"));
        Check<T5Parser>(which, Sampler.Load(".t5"));
        Check<T6Parser>(which, Sampler.Load(".t6"));
        Check<T7Parser>(which, Sampler.Load(".t7"));
        Check<T8Parser>(which, Sampler.Load(".t8"));
    }
}

void Check<ParserType>(int which, IEnumerable<Sample> samples)
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

            var parser = new ParserType();
            var ok = parser.Parse(source);
            if (!ok)
            {
                var furthest = 0;
                foreach (var m in parser.__Core.__Matchers)
                {
                    foreach (var c in m.Contexts.Values)
                    {
                        if (c.Nexts.Count > 0)
                        {
                            foreach (var next in c.Nexts)
                            {
                                if (next.Offset > furthest)
                                {
                                    furthest = next.Offset;
                                }
                            }
                        }
                    }
                }
            }
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
                        var enumerator = new SppfEnumerator(root, writer);
                        var cnt = enumerator.Count();
                        if (cnt <= 2000)
                        {
                            var enumCount = enumerator.Enum();
                            if (sample.Count >= 0)
                            {
                                //Assert(enumCount == sample.Count);
                            }
                        }
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
            Console.WriteLine(sample.Name);

            var ast = Six.Input.Builder.Build(sample.Name, sample.Content);
            var ebnf = new EbnfCreator(ast).Create();

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
