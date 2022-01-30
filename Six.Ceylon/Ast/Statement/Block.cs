namespace Six.Ceylon.Ast
{
    public sealed record Block(ImportList imports, StatementList statements) : Expr.Specifier;
}
