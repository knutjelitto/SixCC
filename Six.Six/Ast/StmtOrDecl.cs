using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface StmtOrDecl : TreeNode
    {
    }

    public sealed record Statelarations(IRNode Tree, IEnumerable<StmtOrDecl> Items)
        : Many<StmtOrDecl>(Tree, Items)
    {
        public Statelarations(IRNode Tree, params StmtOrDecl[] items)
            : this(Tree, items.AsEnumerable())
        { }
    }
}
