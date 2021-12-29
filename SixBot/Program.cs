using Six.Gen.Ebnf;
using Six.Samples;
using Six.Core.Errors;
using SixBot;
using Six.Gen;
using Six.Runtime.Sppf;
using Six.Runtime.Tree;

var profile = false;
var minimal = false;

if (profile)
{
    var num = 850;
    Check<CeylonParser>(1, Sampler.LoadCeylon().OrderBy(s => s.Content.Length).Skip(num-1).Take(1));
}
else
{
    CheckAllT(0);
    Check<T1Parser>(0, Sampler.Load(".t1"));
    Check<T2Parser>(0, Sampler.Load(".t2"));
    Check<T3Parser>(0, Sampler.Load(".t3"));
    Check<T4Parser>(0, Sampler.Load(".t4"));
    Check<T5Parser>(0, Sampler.Load(".t5"));
    Check<T6Parser>(0, Sampler.Load(".t6"));
    Check<T7Parser>(0, Sampler.Load(".t7"));
    Check<T8Parser>(0, Sampler.Load(".t8"));
    //Check<CeylonParser>(4, Sampler.LoadCeylon().OrderByDescending(s => s.Content.Length));
    //Check<CeylonParser>(-1, Sampler.LoadCeylon().OrderByDescending(s => s.Content.Length));
    Check<CeylonParser>(0, Sampler.LoadCeylonLanguage().Take(1));
    Check<SixParser>(0, Sampler.LoadSix());
    CheckJson(false, Sampler.LoadJson());
    CheckGenerate(true);
    Console.Write("any key ... ");
    Console.ReadKey(true);
}

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

    var parser = new ParserType();

    var maxCounted = 0;

    foreach (var sample in samples)
    {
        count++;

        var content = (sample.Content.Length < 20 ? sample.Content : sample.Content[..20] + " ...").Esc();
        Console.WriteLine($"{typeof(ParserType).Name,-12} {count} check {sample.Name} {content}");

        if (which == -1 || which == count)
        {
            var source = Source.FromString(sample.Name, sample.Content);

            parser.Reset();
            var ok = parser.Parse(source);

            if (!ok)
            {
                var furthest = 0;
                var contexts = parser.__Core.__Matchers
                    .SelectMany(m => m.Matches())
                    .Where(c => c != null)
                    .OrderByDescending(c => c!.Nexts.Last())
                    .ThenByDescending(c => c!.Nexts.Last().Offset - c!.Start.Offset)
                    .ToList();
                foreach (var m in parser.__Core.__Matchers)
                {
                    var context = m.Furthest();
                    if (context != null)
                    {
                        if (context.Start.Offset > furthest)
                        {
                            furthest = context.Start.Offset;
                        }
                    }
                }

                Console.WriteLine($"furthest: {new Cursor(source, furthest)}");
                break;
            }
            if (ok)
            {
                if (minimal)
                {
                    continue;
                }

                var builder = new SppfBuilder(source, parser);
                var root = builder.BuildSppf();
                if (root != null)
                {
                    var file = $"{count:D4}-{Path.GetFileNameWithoutExtension(source.Name)}";
                    using (var writer = $"{parser.__Name}-{file}-sppf.txt".Writer())
                    {
                        new SppfDumper(root, writer).Dump();
                    }
                    using (var writer = $"{parser.__Name}-{file}-enum.txt".Writer())
                    {
                        var enumerator = new SppfEnumerator(root, writer);
                        var counted = enumerator.Count();
                        writer.WriteLine($"counted: {counted}");
                        if (sample.Count >= 0)
                        {
                            if (counted > maxCounted)
                            {
                                maxCounted = counted;
                            }

                            if (counted != sample.Count)
                            {
                                if (counted >= 2)
                                {
                                    Assert(true);
                                    //break;
                                }
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

            using (var writer = $"{ast.Name}-ast.txt".Writer())
            {
                var dumper = new Six.Ast.AstDumper(writer, ast);
                dumper.Dump();
            }

            using (var generator = new EbnfCsGenerator())
            {
                generator.Generate(ast.Name, sample.Content);

                var ebnf = generator.Grammar;

                if (ebnf != null)
                {
                    using (var writer = $"{ebnf.Name}-ebnf.txt".Writer())
                    {
                        new EbnfDumper(ebnf).Dump(writer);
                    }

                    var generated = generator.ToString();

                    using (var writer = $"{ebnf.Name}.gen.cs".Writer())
                    {
                        writer.Write(generated);
                    }
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
