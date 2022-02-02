namespace Six.Ceylon.Ast
{
    public sealed record Block(Imports Imports, Statements Statements) : Expr.Specifier;
}
