namespace Six.Ceylon.Ast
{
    public interface AstList : AstNode
    {
        IEnumerable<AstNode> Items { get; }
        int Count { get; }
    }
}
