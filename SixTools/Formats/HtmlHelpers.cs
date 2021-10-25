namespace SixTools.Formats
{
    public static class HtmlHelpers
    {
        public static IDisposable TagIndent(this Writer writer, string tag, string klass = "")
        {
            return new Indent(writer, tag, klass);
        }

        private sealed class Indent : IDisposable
        {
            private readonly Writer writer;
            private readonly string tag;

            public Indent(Writer writer, string tag, string klass)
            {
                this.writer = writer;
                this.tag = tag;
                klass = string.IsNullOrWhiteSpace(klass) ? string.Empty : $" class='{klass}'";

                writer.WriteLine($"<{tag}{klass}>");
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
