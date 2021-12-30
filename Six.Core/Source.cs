﻿namespace Six.Core
{
    public class Source
    {
        private static readonly string lineEndings = "\u000A\u000B\u000C\u000D\u0085\u2028\u2029";
        private static readonly string otherLineEndings = "\u000B\u000C\u0085\u2028\u2029";

        private readonly Lazy<List<int>> lazyLines;

        private Source(string name, string content)
        {
            Name = name;
            Content = content;

            lazyLines = new Lazy<List<int>>(() =>
            {
                return FindLines();
            });
        }

        public readonly string Content;

        public string Name { get; }
        public int Length => Content.Length;
        protected List<int> Lines => lazyLines.Value;
        public int LineCount => Lines.Count;

        public string Text => Content;

        public char this[int index] => Content[index];
        public bool IsEnd(int index) => index >= Content.Length;

        public static Source FromFile(string path)
        {
            return new Source(path, File.ReadAllText(path));
        }

        public static Source FromString(string content)
        {
            return new Source(string.Empty, content);
        }

        public static Source FromString(string name, string content)
        {
            return new Source(name, content);
        }

        public (int lineNo, int colNo) GetLineAndColumn(int offset)
        {
            var lineNo = GetLineNoFromIndex(offset);
            var colNo = offset - GetIndexFromLineNo(lineNo) + 1;

            return (lineNo, colNo);
        }

        public string GetLine(int lineNo)
        {
            var start = GetIndexFromLineNo(lineNo);
            var next = GetIndexFromLineNo(lineNo + 1);
            while (next > start && lineEndings.Contains(Content[next - 1]))
            {
                next -= 1;
            }

            return GetSpan(start, next - start);
        }

        public IEnumerable<string> GetLines()
        {
            for (var lineNo = 1; lineNo <= LineCount; ++lineNo)
            {
                yield return GetLine(lineNo).ToString();
            }
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

        public string GetSpan(int start, int length)
        {
            return Content.Substring(start, length);
        }

        public string GetText(int start, int length)
        {
            return Content.Substring(start, length);
        }

        public string Report(int offset)
        {
            var name = Name;
            var (line, column) = GetLineAndColumn(offset);
            return $"{name}({line},{column})";
        }

        public string Report(int start, int end)
        {
            var name = Name;
            var (sline, scolumn) = GetLineAndColumn(start);
            var (eline, ecolumn) = GetLineAndColumn(end);
            return $"{name}({sline},{scolumn}-{eline},{ecolumn})";
        }

        public string LCO(int offset)
        {
            var name = Name;
            var (line, column) = GetLineAndColumn(offset);
            return $"{name}({line},{column},{offset})";
        }

        private List<int> FindLines()
        {
            var lines = new List<int>(10000);
            lines.Add(0);
            var c2 = '\0';
            for (var i = 0; i != Content.Length; i++)
            {
                var c1 = c2;
                c2 = Content[i];

                // is c1 c2 a line ending sequence?
                if (IsLineEnding(c1, c2))
                {
                    // are we late to detect MacOS style?
                    if (c1 == '\u000D' && c2 != '\u000A')
                        AddLine(i);
                    else
                        AddLine(i + 1);
                }
            }

            bool IsLineEnding(char c1, char c2)
            {
                return otherLineEndings.Contains(c2) || c1 == '\u000D' || c2 == '\u000A';
            }

            void AddLine(int index)
            {
                if (lines.Count >= lines.Capacity)
                {
                    lines.Capacity = (lines.Capacity * 3) / 2;
                }

                lines.Add(index);
            }

            return lines;
        }

        public int At(int offset)
        {
            if (offset < Text.Length)
            {
                return Text[offset];
            }
            return -1;
        }

        public bool Match(int offset, int cp)
        {
            Assert(cp <= 0xFFFF);
            if (offset < Text.Length)
            {
                return Text[offset] == cp; ;
            }
            return false;
        }

        public bool Match(int offset, string text)
        {
            if (offset + text.Length <= Text.Length)
            {
                return Text.Substring(offset, text.Length) == text;
            }
            return false;
        }
    }
}
