using Six.Core;

namespace Six.Input
{
    public class Source : ISource
    {
        public static readonly Source Empty = new(string.Empty, string.Empty);

        private readonly List<int> Lines = new();

        public Source(string name, string content)
        {
            Name = name;
            Content = content;
            Lines.Add(0);
        }

        public int this[int index] => index < Content.Length ? Content[index] : -1;

        public string Content { get; }

        public int Length => Content.Length;

        public string Name { get; }

        public void IndexNewline(int index)
        {
            Lines.Add(index);
        }

        public int LineNumber(int offset)
        {
            var lineOffset = Lines.BinarySearch(offset - 1);
            if (lineOffset < 0)
            {
                lineOffset = ~lineOffset;
            }
            return lineOffset + 1;
        }

        public (int lineNumber, int columnNumber) GetLineAndColumn(int index)
        {
            var lineNumber = GetLineNoFromIndex(index);
            var columnNumber = index - GetIndexFromLineNo(lineNumber) + 1;

            return (lineNumber, columnNumber);
        }

        public int GetIndexFromLineNo(int lineNo)
        {
            var lineIdx = Math.Max(0, Math.Min(lineNo - 1, Lines.Count - 1));

            return Lines[lineIdx];
        }

        public int GetLineNoFromIndex(int index)
        {
            var line = Lines.BinarySearch(Math.Max(0, index));
            if (line < 0)
            {
                return ~line;
            }
            return line + 1;
        }

        public string GetText(int start, int length)
        {
            return Content.Substring(start, length);
        }

        public bool IsEnd(int index) => index >= Content.Length;
    }
}
