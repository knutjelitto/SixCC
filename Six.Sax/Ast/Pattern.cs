using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Pattern : TreeNode
    {
        public sealed record Ident(IRNode Tree, Name Name) : Pattern;
    }
}
