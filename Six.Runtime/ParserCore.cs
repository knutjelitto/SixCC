using Six.Core;

namespace Six.Runtime
{
    public abstract class ParserCore
    {
        public readonly string __Name;
        protected readonly ImplementationCore __Core;

        protected ParserCore()
            : this("<noname>", new ImplementationCore())
        {
        }

        protected ParserCore(string name, ImplementationCore core)
        {
            __Name = name;
            __Core = core;
        }

        public void Match(string name, string content)
        {
            var source = Source.FromString(name, content);
            var cursor = new Cursor(source, 0);
            var successCounter = 0;
            var failureCounter = 0;
            var lastfailure = cursor;

            var watch = new Stopwatch();
            watch.Start();

            __Core.__Start.Match(cursor,
                success =>
                {
                    Report("OK  ", ++successCounter, success.Offset);
                });

            if (successCounter == 0)
            {
                Report("FAIL", failureCounter, lastfailure.Offset);
            }

            void Report(string what, int counter, int offset)
            {
                var elapsed = watch.Elapsed;
                var rep = source.LCO(offset);
                var lines = source.GetLineNoFromIndex(offset);
                var ms = Math.Round(elapsed.TotalMilliseconds, 1);
                var cps = Math.Round(offset / elapsed.TotalSeconds, 0);
                var lps = Math.Round(lines / elapsed.TotalSeconds, 0);
                Console.WriteLine($"{what}#{counter} {__Name} {rep}");
                Console.WriteLine($"elapsed: {ms} ms, {cps} cps, {lps} lps");
            }
        }

        public bool Recognize(string name, string content)
        {
            var source = Source.FromString(name, content);
            var cursor = new Cursor(source, 0);
            var ok = false;

            __Core.__Start.Match(cursor,
                success =>
                {
                    ok = true;
                });

            return ok;
        }
    }
}
