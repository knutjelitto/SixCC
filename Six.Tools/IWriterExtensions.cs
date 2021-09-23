using System;

namespace Six.Tools
{
    public static class IWriterExtensions
    {
        public static IDisposable Block(this IWriter writer, string? text = null)
        {
            if (text != null)
            {
                writer.WriteLine(text);
            }
            return writer.Indent(() => writer.WriteLine("{"), () => writer.WriteLine("}"));
        }

        public static IDisposable Indent(this IWriter writer, string label)
        {
            writer.WriteLine(label);
            return writer.Indent();
        }
    }
}
