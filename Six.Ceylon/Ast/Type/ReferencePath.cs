namespace Six.Ceylon.Ast
{
    public sealed record ReferencePath(bool Package, IdentifierList Names) : AstNode
    {
    }
}
