namespace Six.Ceylon.Ast
{
    public sealed record ReferencePath(bool Package, Identifiers Names) : AstNode
    {
    }
}
