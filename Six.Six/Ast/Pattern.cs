using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Pattern : TreeNode
    {
        public sealed record Ident(IRNode Tree, Name Name) : Pattern;
    }
}
