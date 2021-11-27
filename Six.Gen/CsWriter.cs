namespace Six.Gen
{
    internal static class CsWriter
    {
        public static string CsString(this string text)
        {
            return $"\"{string.Join(string.Empty, text.Select(chr => Escape(chr)))}\"";

            static string Escape(char chr)
            {
                switch (chr)
                {
                    case '"':
                        return "\\\"";
                    case '\\':
                        return "\\\\";
                    case '\0':
                        return "\\0";
                    case '\a':
                        return "\\a";
                    case '\b':
                        return "\\b";
                    case '\f':
                        return "\\f";
                    case '\n':
                        return "\\n";
                    case '\r':
                        return "\\r";
                    case '\t':
                        return "\\t";
                    case '\v':
                        return "\\v";
                    default:
                        return chr.ToString();
                }
            }
        }

        public static void L(this Writer writer)
        {
            writer.WriteLine();
        }

        public static void L(this Writer writer, string text)
        {
            writer.WriteLine(text);
        }

        public static IDisposable Block(this Writer writer, string head)
        {
            writer.WriteLine(head);
            return new Unblock(writer, "{", "}");
        }

        public static void Block(this Writer writer, string head, Action content)
        {
            writer.WriteLine(head);
            writer.WriteLine("{");
            using (writer.Indent())
            {
                content();
            }
            writer.WriteLine("}");
        }

        public static void Initializer(this Writer writer, string head, Action content)
        {
            writer.WriteLine(head);
            writer.WriteLine("{");
            using (writer.Indent())
            {
                content();
            }
            writer.WriteLine("};");
        }

        private class Unblock : IDisposable
        {
            private readonly Writer writer;
            private readonly string start;
            private readonly string end;

            public Unblock(Writer writer, string start, string end)
            {
                this.writer = writer;
                this.start = start;
                this.end = end;

                writer.WriteLine(this.start);
                writer.Plus();
            }

            public void Dispose()
            {
                writer.Minus();
                writer.WriteLine(end);
            }
        }
    }
}
