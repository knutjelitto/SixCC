namespace Six.Ceylon.Ast
{
    public interface Typo
    {
        public sealed record Instance : Typo;

        public sealed record Infix(Typo left, string Op, Typo Right) : Typo;

        public sealed record Prefix(string Op, Typo Right) : Typo;

        public sealed record Postfix(Typo left, string Op) : Typo;

        public sealed record Iterable(Typo? type) : Typo;

        public sealed record Specifier(Typo type) : Typo;

        public sealed record Varianced(string? variance, Typo Typo) : Typo;

        public sealed record Array(Typo Typo, NaturalNumber? Size) : Typo;


    }
}
