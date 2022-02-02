namespace Six.Ceylon.Ast
{
    public record Unit(
        Imports Imports,
        Namespace Namespace,
        Declarations Declarations) : AstNode;
}
