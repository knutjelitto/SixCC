using Six.Core;
using Six.Runtime.Sppf;
using Six.Runtime.Types;

namespace Six.Runtime
{
    public abstract class Compiler<TParser>
        where TParser : Parser, new()
    {
        protected readonly TParser parser = new();
        protected RuleIndex? ruleIndex;

        protected Compiler()
        {
        }

        public bool BuildFile(SourceFile job)
        {
            var ok = Ok(() => Parse(job));

            if (!ok)
            {
                var furthest =
                    (from matcher in parser.__Core.__Matchers
                     from ctx in matcher.NonMatches()
                     where ctx != null
                     orderby ctx.Start.Offset descending
                     group ctx by ctx.Start.Offset into ctxgroup
                     select ctxgroup.AsEnumerable())
                     .First();

                var terminals =
                    (from ctx in furthest
                     where ctx.Matcher is Matchers.String
                     let terminal = ((Matchers.String)ctx.Matcher).Text
                     orderby terminal
                     select terminal)
                    .Distinct()
                    .ToList();

                var start = furthest.First().Core;
                var lco = start.Source.NameLineColumn(start.Offset);

                var expected = "'" + string.Join("' | '", terminals) + "'";
                var message = $"{lco}: expected {expected}";

                Console.WriteLine();
                Console.WriteLine($"{message}");

                return false;
            }

            var sppf = SppfBuilder.Build(job.Source, parser, ruleIndex);

            if (sppf == null)
            {
                Console.WriteLine();
                Console.WriteLine($"sppf: {job.ShortPath}");

                return false;
            }

            job.Sppf = sppf;

            job.Tree = TypedBuilder.Build(sppf);

            return true;
        }

        private bool Parse(SourceFile job)
        {
            var source = Source.FromString(job.ShortPath, job.Content);
            parser.Reset();
            var timer = new Stopwatch();
            timer.Start();
            var ok = parser.Parse(source);
            timer.Stop();
            job.ParseTime = timer.Elapsed;
            job.ParseLines = source.LineCount;
            return ok;
        }

        private static bool Ok(Func<bool> action)
        {
            Console.Write("?");

            var ok = action();

            if (ok)
            {
                Console.Write("\b.");
            }
            else
            {
                Console.Write("\b×");
            }

            return ok;
        }
    }
}
