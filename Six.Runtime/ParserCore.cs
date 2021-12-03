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

            __Core.__Start.Match(new Context(cursor,
                success =>
                {
                    var elapsed = watch.Elapsed;
                    var rep = source.LCO(success.Offset);
                    var lines = source.GetLineNoFromIndex(success.Offset);
                    var ms = Math.Round(elapsed.TotalMilliseconds);
                    var cps = Math.Round(success.Offset / elapsed.TotalSeconds, 0);
                    var lps = Math.Round(lines / elapsed.TotalSeconds, 0);
                    Console.WriteLine($"OK  #{++successCounter} {__Name} {rep}");
                    Console.WriteLine($"elapsed: {ms} ms, {cps} cps, {lps} lps");
                },
                failure =>
                {
                    if (failure > lastfailure)
                    {
                        lastfailure = failure;
                    }
                    ++failureCounter;
                }));

            if (successCounter == 0)
            {
                var elapsed = watch.Elapsed;
                var rep = source.LCO(lastfailure.Offset);
                var lines = source.GetLineNoFromIndex(lastfailure.Offset);
                var ms = Math.Round(elapsed.TotalMilliseconds);
                var cps = Math.Round(lastfailure.Offset / elapsed.TotalSeconds, 0);
                var lps = Math.Round(lines / elapsed.TotalSeconds, 0);
                Console.WriteLine($"FAIL#{failureCounter} {__Name} {rep}");
                Console.WriteLine($"elapsed: {ms} ms, {cps} cps, {lps} lps");
            }
        }
    }
}
