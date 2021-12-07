using Six.Runtime.Matchers;

namespace SixBot
{
#pragma warning disable IDE1006 // Naming Styles
    public class TreeBuilder : ITreeBuilder, IDisposable
    {
        private readonly Source source;
        private readonly ParserCore parser;
        private readonly Writer writer;
        private readonly HashSet<Key> already = new();

        public TreeBuilder(Source source, ParserCore parser)
        {
            this.source = source;
            this.parser = parser;
            writer = $"{parser.__Name}-match.txt".Writer();
        }

        public void Build()
        {
            already.Clear();
            Build(parser.__Core.__Start, new Cursor(source, 0), new Cursor(source, source.Length));
        }

        void IDisposable.Dispose()
        {
            writer.Dispose();
        }

        private void Build(Matcher matcher, Cursor start, Cursor end)
        {
            indent($"({matcher}, {start.Offset}, {end.Offset})",
                () =>
                {
                    var key = new Key(start.Offset, end.Offset, matcher);
                    if (already.Contains(key))
                    {
                        wl($"--> ({matcher}, {start.Offset}, {end.Offset})");
                        return;
                    }
                    already.Add(key);
                    if (!matcher.Contexts.TryGetValue(start, out var context))
                    {
                        return;
                    }
                    //wl($"---------------------------------{context}");

                    Build(start, end, matcher.Matchers);
                });
        }

        private void Build(Cursor start, Cursor end, IEnumerable<Matcher> rest)
        {
            foreach (var matcher in rest)
            {
                Build(matcher, start, end);
            }
        }

        protected void wl()
        {
            writer.WriteLine();
        }

        protected void wl(string content)
        {
            writer.WriteLine(content);
        }

        protected void w(string content)
        {
            writer.Write(content);
        }

        protected void cramp(string head, Action content)
        {
            w("(");
            wl(head);
            using (writer.Indent())
            {
                content();
            }
            w(")");
        }

        protected void indent(string head, Action content)
        {
            wl(head);
            using (writer.Indent())
            {
                content();
            }
        }

        private record Key(int Start, int End, Matcher Matcher)
        {
        }
    }
}
