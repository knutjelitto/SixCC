using Six.Core;
using Six.Runtime.Matchers;
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

        public bool BuildFile(FileJob job)
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

                var start = furthest.First().Start;
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
                Console.WriteLine($"sppf: {job.Fullname}");

                return false;
            }

            job.Tree = TypedBuilder.Build(sppf);

            return true;
        }

        private bool Parse(FileJob job)
        {
            var source = Source.FromString(job.Fullname, job.Content);
            parser.Reset();
            var timer = new Stopwatch();
            timer.Start();
            var ok = parser.Parse(source);
            timer.Stop();
            job.ParseTime = timer.Elapsed;
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
