using Six.Runtime;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonParserAst;

namespace Six.Ceylon
{
    public abstract class Compiler<TParser>
        where TParser : Runtime.Parser, new()
    {
        private readonly TParser parser = new TParser();

        public bool BuildFile(FileJob job)
        {
            var ok = Ok(() => Parse(job));

            if (!ok)
            {
                Console.WriteLine($"parse: {job.Fullname}");

                return false;
            }

            var sppf = SppfBuilder.Build(job.Source, parser);

            if (sppf == null)
            {
                Console.WriteLine($"sppf: {job.Fullname}");

                return false;
            }

            job.Tree = TypedBuilder.Build(sppf);

            new DynamicCeylonVisitor().Walk(job.Tree);

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

        private bool Ok(Func<bool> action)
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
