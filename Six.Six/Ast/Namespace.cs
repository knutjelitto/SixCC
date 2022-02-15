using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public record Namespace(IRNode Tree, Prelude Prelude, Names Names) : TreeNode;
}
