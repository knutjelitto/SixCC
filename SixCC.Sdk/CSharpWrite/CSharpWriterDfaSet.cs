using SixCC.Sdk.Build;
using SixCC.Sdk.Commons;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.CSharpWrite
{
    public class CSharpWriterDfaSet : CSharpWriterTools
    {
        private readonly CsWriter writer;

        public CSharpWriterDfaSet(CSharpContext ctx)
            : base(ctx)
        {
            this.writer = ctx.Writer;
        }

        public void Write()
        {
            writer.Block($"public static {Ctx.DfaSetType} CreateDfaSet()", () =>
            {
                var compact = new CompactDfaWriter(Grammar);

                var bytes = new CompressWriter().Compress(compact.Write());

                WriteByteArray("byte[] bytes = ", bytes);

                writer.WriteLine();
                
                writer.WriteLine($"return new CompactDfaReader(new BinReader(new CompressReader().Uncompress(bytes))).Read();");
            });
        }
    }
}
