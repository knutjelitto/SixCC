namespace Six.Ceylon.Ast
{
    public interface Type : CaseItem
    {
        public sealed record Instance : Type;

        public sealed record Entry(Type left, Type Right) : Type;
        
        public sealed record Union(Type left, Type Right) : Type;
        
        public sealed record Intersection(Type left, Type Right) : Type;

        public sealed record Prefix(string Op, Type Right) : Type;

        public sealed record Nullable(Type left) : Type;

        public sealed record Iterable(Type? type) : Type;

        public sealed record Specifier(Type type) : Type;

        public sealed record Varianced(string? variance, Type Typo) : Type;

        public sealed record Defaulted(Type Typo) : Type;

        public sealed record Spread(Type Typo) : Type;

        public sealed record Variadic(Type Typo, string op) : Type;

        public sealed record Array(Type Typo, NaturalNumber? Size) : Type;

        public sealed record Tuple(Type type) : Type;

        public sealed record Function(Type Type, Type Arguments) : Type;

        public sealed record CaseType(bool Package, Identifier Name) : Type;

        public sealed record PackageType(TypePath Path) : Type;
    }
}
