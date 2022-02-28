using Six.Runtime.Types;

using S = Six.Six.Sema;

namespace Six.Six.Ast
{
    public interface Node
    {
    }

    public interface TreeNode : Node
    {
        IRNode Tree { get; }
    }

    public interface NodeList : TreeNode
    {
        IEnumerable<TreeNode> Items { get; }
        int Count { get; }
    }
}
