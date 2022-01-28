namespace Six.Ceylon.Ast
{
    public record Typo
    {
        //TODO

        public sealed record Infix(Typo left, string Op, Typo Right) : Typo;
        public sealed record Prefix(string Op, Typo Right) : Typo;
        public sealed record Postfix(Typo left, string Op) : Typo;
        public sealed record Iterable(Typo? type) : Typo;
        public sealed record Specifier(Typo type) : Typo;

    }
}
