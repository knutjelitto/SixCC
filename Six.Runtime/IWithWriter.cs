using Six.Core;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Runtime
{
    public interface IWithWriter
    {
        Writer Writer { get; }

        public void wl(string content) => Writer.WriteLine(content);
        public void wl() => Writer.WriteLine();
        public void w(string content) => Writer.Write(content);
        public void indent(Action content)
        {
            using (Writer.Indent())
            {
                content();
            }
        }
    }
}
