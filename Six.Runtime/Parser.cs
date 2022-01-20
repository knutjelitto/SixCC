using Six.Core;

namespace Six.Runtime
{
    public abstract class Parser
    {
        public readonly string __Name;
        public readonly ImplementationCore __Core;

        protected Parser()
            : this("<noname>", new ImplementationCore())
        {
        }

        protected Parser(string name, ImplementationCore core)
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
            var ok = false;

            __Core.__Start.Match(cursor,
                matched =>
                {
                    ok = true;
                });

            return ok;
        }


        public bool ParseVerbose(Source source)
        {
            var cursor = new Cursor(source, 0);
            var ok = false;

            var watch = new Stopwatch();
            watch.Start();

            __Core.__Start.Match(cursor,
                success =>
                {
                    ok = true;
                });

            watch.Stop();

            if (!ok)
            {
                Report("FAIL", 0, 0);
            }
            else
            {
                var contexts = 0;
                var unused = 0;
                foreach (var matcher in __Core.__Matchers)
                {
                    contexts += matcher.Contexts.Count;
                    var unmatcheds = matcher.Contexts.Where(kv => kv.Value.Nexts.Count == 0).Select(kv => kv.Key);
                    foreach (var unmatched in unmatcheds)
                    {
                        matcher.Contexts.Remove(unmatched);
                        unused += 1;
                    }
                }

                var percent = Math.Round((contexts - unused) * 100.0 / contexts, 1);

                Report("OK  ", source.Length, percent);
            }

            return ok;

            void Report(string what, int offset, double percent)
            {
                var elapsed = watch.Elapsed;
                var rep = source.NameLineColumnOffset(offset);
                var lines = source.GetLineNoFromIndex(offset);
                var ms = Math.Round(elapsed.TotalMilliseconds, 1);
                var cps = Math.Round(offset / elapsed.TotalSeconds, 0);
                var lps = Math.Round(lines / elapsed.TotalSeconds, 0);
                Console.WriteLine($"    {what} {__Name} {rep}");
                Console.WriteLine($"    elapsed: {ms} ms, {cps} cps, {lps} lps  {percent} %");
            }
        }

        public bool ParseVerbose(string name, string content)
        {
            var source = Source.FromString(name, content);

            return ParseVerbose(source);
        }
    }
}
