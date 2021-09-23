using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Six.Tools
{
    public class LinesWriter : IndentWriter, IEnumerable<string>
    {
        public LinesWriter(string prefix = "")
            : base(new BaseLines(prefix))
        {
        }

        public IReadOnlyList<string> Lines => ((BaseLines)Writer).Lines;

        public IEnumerator<string> GetEnumerator() => Lines.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void ToWriter(IWriter writer)
        {
            foreach (var line in Lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    writer.WriteLine();
                }
                else
                {
                    writer.WriteLine(line);
                }
            }
        }

        private class BaseLines : IBaseWriter
        {
            private readonly List<string> lines = new();
            private readonly string prefix;
            private readonly StringBuilder current = new();

            public BaseLines(string prefix = "")
            {
                this.prefix = prefix;
                _ = current.Append(prefix);
            }

            public IReadOnlyList<string> Lines => lines;

            public void Write(string text)
            {
                _ = current.Append(text);
            }

            public void WriteLine()
            {
                lines.Add(current.ToString());
                _ = current.Clear();
                _ = current.Append(prefix);
            }
        }
    }
}
