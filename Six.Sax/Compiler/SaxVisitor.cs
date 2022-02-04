using Six.Runtime;
using static Six.Sax.SaxTree;

namespace Six.Sax.Compiler
{
    public partial class SaxVisitor : DynamicSaxVisitor
    {
        public void Walk(SourceFile source)
        {
            if (source.Tree != null)
            {
                Walk(source.Tree);
            }
        }
    }
}
