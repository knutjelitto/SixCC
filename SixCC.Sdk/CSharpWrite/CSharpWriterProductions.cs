using System.Diagnostics;
using System.Linq;

using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;

#nullable enable

namespace SixCC.Sdk.CSharpWrite
{
    public class CSharpWriterProductions : CSharpWriterTools
    {
        private readonly CsWriter writer;

        public CSharpWriterProductions(CSharpContext ctx)
            : base(ctx)
        {
            this.writer = ctx.Writer;
        }

        public void Write()
        {
            writer.Data("private static readonly Production[] productions = ", () =>
            {
                foreach (var production in Grammar.Productions)
                {
                    var drops = string.Join(",", production.Drops.Select(Bool));
                    drops = $"new bool[]{{{drops}}}";
                    var promotes = string.Join(",", production.Promotes.Select(Bool));
                    promotes = $"new bool[]{{{promotes}}}";

                    var visual = production.ToString();
                    var sep = drops.Length > 0 ? ", " : string.Empty;
                    writer.WriteLine($"new Production({production.Nonterminal.Name}, \"{visual}\", {drops}, {promotes}),");
                }
            });
        }
    }
}
