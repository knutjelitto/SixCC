using System.Diagnostics;

using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;
using SixCC.Sdk.Build;
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.CSharpWrite
{
    public class CSharpWriterParseTable : CSharpWriterTools
    {
        private readonly CsWriter writer;

        public CSharpWriterParseTable(CSharpContext ctx)
            : base(ctx)
        {
            this.writer = ctx.Writer;
        }

        public void Write()
        {
            writer.Block($"public static {Ctx.ParseTableType} CreateParseTable()", () =>
            {
                Debug.Assert(Grammar.ParseTable != null);

                var compact = new CompactTableWriter(Grammar.ParseTable);

                var bytes = new CompressWriter().Compress(compact.Write());

                WriteByteArray("byte[] bytes = ", bytes);

                writer.WriteLine();

                writer.WriteLine($"return new CompactTableReader(new BinReader(new CompressReader().Uncompress(bytes))).Read();");
            });
        }
    }
}
