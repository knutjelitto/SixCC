using Six.Core;

namespace Six.Sax.Sema
{
    public static class DumpExtensions
    {
        public static void DumpDeclarations(this Container container, Writer writer)
        {
            using (writer.Indent())
            {
                foreach (var dc in container.GetDeclarations())
                {
                    var attrs = new StringBuilder();
                    attrs.Append(dc.IsShared() ? "S" : " ");
                    attrs.Append(dc.IsNative() ? "N" : " ");

                    writer.WriteLine($"{dc.GetKind(),-15} [{attrs}] {dc.GetName()} - {dc.GetLocation()}");

                    var line = dc.Content.GetDeclarations().Any() && dc.Content.GetStatements().Any();
                    dc.Content.DumpDeclarations(writer);
                    if (line)
                    {
                        writer.WriteLine("--");
                    }
                    dc.Content.DumpStatements(writer);
                }
            }
        }

        public static void DumpStatements(this Container container, Writer writer)
        {
            using (writer.Indent())
            {
                foreach (var st in container.GetStatements())
                {
                    writer.WriteLine($"XXXXX {st.GetKind(),-15}");
                }
            }
        }
    }
}
