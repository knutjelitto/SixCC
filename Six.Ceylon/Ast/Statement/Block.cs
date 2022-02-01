namespace Six.Ceylon.Ast
{
    public sealed record Block(Imports imports, StatementList statements) : Expr.Specifier;
}
