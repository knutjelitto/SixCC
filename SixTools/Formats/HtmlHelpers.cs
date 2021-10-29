namespace SixTools.Formats
{
    public static class HtmlHelpers
    {
        public static IDisposable TagIndent(this Writer writer, string tag)
        {
            return writer.TagIndent(tag, string.Empty);
        }

        public static IDisposable TagIndent(this Writer writer, string tag, string cls, params string[] attributes)
        {
            var attrs = new List<string>();
            if (!string.IsNullOrWhiteSpace(cls))
            {
                attrs.Add($"class=\"{cls}\"");
            }
            attrs.AddRange(attributes);

            writer.Write($"<{tag}");
            if (attributes.Length > 0)
            {
                writer.Write(" ");
                writer.Write(string.Join(" ", attrs));
            }
            writer.WriteLine(">");

            return new Indent(writer, tag);
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
    }
}
