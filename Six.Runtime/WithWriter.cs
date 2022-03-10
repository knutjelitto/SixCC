using Six.Core;

namespace Six.Runtime
{
    public class WithWriter : IWithWriter
    {
        public WithWriter(Writer writer)
        {
            Writer = writer;
        }

        public Writer Writer { get; }

        public void wl(string content) => Writer.WriteLine(content);
        public void wlif(string? content)
        {
            if (content == null)
            {
                return;
            }
            Writer.WriteLine(content);
        }

        public void wl() => Writer.WriteLine();
        public void w(string content) => Writer.Write(content);

        public void indent(Action content)
        {
            using (Writer.Indent())
            {
                content();
            }
        }

        public void indent(string before, string after, Action content)
        {
            wl(before);
            using (Writer.Indent())
            {
                content();
            }
            wl(after);
        }
    }
}
