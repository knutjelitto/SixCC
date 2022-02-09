using Six.Runtime.Types;

namespace Six.Sax.Ast
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
