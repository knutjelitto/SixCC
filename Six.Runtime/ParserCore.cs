using Six.Core;

namespace Six.Runtime
{
    public abstract class ParserCore
    {
        public readonly string __Name;
        public readonly ImplementationCore __Core;

        protected ParserCore()
            : this("<noname>", new ImplementationCore())
        {
        }

        protected ParserCore(string name, ImplementationCore core)
        {
            __Name = name;
            __Core = core;
        }

        public void Reset()
        {
            __Core.Reset();
        }

        public bool Parse(Source source)
        {
            var cursor = new Cursor(source, 0);
            var successCounter = 0;
            var lastfailure = cursor;

            var watch = new Stopwatch();
            watch.Start();

            __Core.__Start.Match(cursor,
                success =>
                {
                    ++successCounter;
                });

            watch.Stop();

            if (successCounter == 0)
            {
                Report("FAIL", 0, 0, 1000);
                return false;
            }
            else
            {
                var contexts = 0;
                var nulps = 0;
                foreach (var matcher in __Core.__Matchers)
                {
                    contexts += matcher.Contexts.Count;
                    nulps += matcher.Contexts.Where(kv => kv.Value.Nexts.Count == 0).Select(kv => kv.Key).Count();
                }

                var percent = (contexts - nulps) * 100 / contexts;

                Report("OK  ", successCounter, source.Length, percent);
                return true;
            }

            void Report(string what, int counter, int offset, int percent)
            {
                var elapsed = watch.Elapsed;
                var rep = source.LCO(offset);
                var lines = source.GetLineNoFromIndex(offset);
                var ms = Math.Round(elapsed.TotalMilliseconds, 1);
                var cps = Math.Round(offset / elapsed.TotalSeconds, 0);
                var lps = Math.Round(lines / elapsed.TotalSeconds, 0);
                Console.WriteLine($"    {what}#{counter} {__Name} {rep}");
                Console.WriteLine($"    elapsed: {ms} ms, {cps} cps, {lps} lps{percent} {percent} %");
            }
        }

        public bool Parse(string name, string content)
        {
            var source = Source.FromString(name, content);

            return Parse(source);
        }
    }
}
