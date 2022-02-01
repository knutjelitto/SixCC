namespace Six.Ceylon.Ast
{
    public static class Misc
    {
        public sealed record ForIterator(Pattern Variable, Containment Containment) : AstNode;

        public sealed record Containment(string Op, Expr Expr) : AstNode;

    }
}
