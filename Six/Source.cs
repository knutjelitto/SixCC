using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Six
{
    public class Source
    {
        private Source(string path, string name, string text)
        {
            Path = path;
            Name = name;
            Text = text;
            Length = text.Length;
            Index = new List<int>();
        }

        public string Path { get; }
        public string Name { get; }
        public string Text { get; }
        public int Length { get; }
        public List<int> Index { get; }

        public void IndexLine(int offset)
        {
            Debug.Assert(offset == 0 || Text[offset - 1] == '\n');
            Debug.Assert(Index.Count == 0 && offset == 0 || Index[^1] < offset);

            Index.Add(offset);
        }

        public static Source FromFile(string filePath, string name)
        {
            return new Source(filePath, name, File.ReadAllText(filePath));
        }

        public int LineNumber(int offset)
        {
            var index = Index.BinarySearch(offset);
            if (index < 0)
            {
                index = ~index - 1;
            }

            return index + 1;
        }

        public int ColumnNumber(int offset)
        {
            var index = Index.BinarySearch(offset);
            if (index < 0)
            {
                index = ~index - 1;
            }

            return offset - Index[index] + 1;
        }

        public string Report(int offset)
        {
            var name = Name;
            var line = LineNumber(offset);
            var column = ColumnNumber(offset);
            return $"{name}({line},{column})";
        }
    }
}
