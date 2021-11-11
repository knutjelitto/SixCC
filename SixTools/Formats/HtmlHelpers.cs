namespace SixTools.Formats
{
    public static class HtmlHelpers
    {
        public static IDisposable TagIndent(this Writer writer, string tag)
        {
            return writer.TagIndent(tag, string.Empty);
        }

        private static void Common(Writer writer, string tag, string cls, params string[] attributes)
        {
            var attrs = new List<string>();
            if (!string.IsNullOrWhiteSpace(cls))
            {
                attrs.Add($"class=\"{cls}\"");
            }
            attrs.AddRange(attributes.Where(a => !string.IsNullOrWhiteSpace(a)));

            writer.Write($"<{tag}");
            if (attrs.Count > 0)
            {
                writer.Write(" ");
                writer.Write(string.Join(" ", attrs));
            }
        }

        public static IDisposable TagIndent(this Writer writer, string tag, string cls, params string[] attributes)
        {
            Common(writer, tag, cls, attributes);

            writer.WriteLine(">");

            return new Indent(writer, tag);
        }

        public static IDisposable TagStraight(this Writer writer, string tag, string cls, params string[] attributes)
        {
            Common(writer, tag, cls, attributes);

            writer.Write(">");

            return new Straight(writer, tag);
        }

        public static void TagClosed(this Writer writer, string tag, string cls, params string[] attributes)
        {
            Common(writer, tag, cls, attributes);

            writer.Write("/>");
        }

        public static void TagClosedLine(this Writer writer, string tag, string cls, params string[] attributes)
        {
            Common(writer, tag, cls, attributes);

            writer.WriteLine("/>");
        }

        public static void Tagged(this Writer writer, string tag, string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                writer.WriteLine($"<{tag}/>");
            }
            else
            {
                writer.WriteLine($"<{tag}>{content}</{tag}>");
            }
        }

        private sealed class Indent : IDisposable
        {
            private readonly Writer writer;
            private readonly string tag;

            public Indent(Writer writer, string tag)
            {
                this.writer = writer;
                this.tag = tag;
                writer.Plus();
            }

            public void Dispose()
            {
                writer.Minus();
                writer.WriteLine($"</{tag}>");
            }
        }

        private sealed class Straight : IDisposable
        {
            private readonly Writer writer;
            private readonly string tag;

            public Straight(Writer writer, string tag)
            {
                this.writer = writer;
                this.tag = tag;
            }

            public void Dispose()
            {
                writer.Write($"</{tag}>");
            }
        }
    }
}
