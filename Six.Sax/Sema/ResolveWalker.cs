using Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public sealed class ResolveWalker
    {
        public ResolveWalker(Module global)
        {
            Global = global;
        }

        public Module Global { get; }

        public void Walk(IResolveable node)
        {
        }
    }
}
