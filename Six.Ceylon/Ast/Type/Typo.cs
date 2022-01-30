namespace Six.Ceylon.Ast
{
    public interface Typo : CaseItem
    {
        public sealed record Instance : Typo;

        public sealed record Entry(Typo left, Typo Right) : Typo;
        
        public sealed record Union(Typo left, Typo Right) : Typo;
        
        public sealed record Intersection(Typo left, Typo Right) : Typo;

        public sealed record Prefix(string Op, Typo Right) : Typo;

        public sealed record Postfix(Typo left, string Op) : Typo;

        public sealed record Iterable(Typo? type) : Typo;

        public sealed record Specifier(Typo type) : Typo;

        public sealed record Varianced(string? variance, Typo Typo) : Typo;

        public sealed record Defaulted(Typo Typo) : Typo;

        public sealed record Spread(Typo Typo) : Typo;

        public sealed record Variadic(Typo Typo, string op) : Typo;

        public sealed record Array(Typo Typo, NaturalNumber? Size) : Typo;

        public sealed record Tuple(Typo type) : Typo;

        public sealed record Function(Typo Type, Typo Arguments) : Typo;

        public sealed record CaseType(bool Package, Identifier Name) : Typo;

        public sealed record PackageType(TypePath Path) : Typo;
    }
}
