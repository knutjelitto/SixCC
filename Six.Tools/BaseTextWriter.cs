using System.IO;

namespace Six.Tools
{
    public class BaseTextWriter : IBaseWriter
    {
        public BaseTextWriter(TextWriter writer)
        {
            Writer = writer;
        }

        public TextWriter Writer { get; }

        public void Write(string text)
        {
            Writer.Write(text);
        }

        public void WriteLine()
        {
            Writer.WriteLine();
        }
    }
}
