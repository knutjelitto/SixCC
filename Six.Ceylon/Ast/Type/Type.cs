namespace Six.Ceylon.Ast
{
    public interface Type : CaseItem
    {
        public sealed record Entry(string Op, Type Left, Type Right) : Type;
        
        public sealed record Union(string Op, Type Left, Type Right) : Type;
        
        public sealed record Intersection(string Op, Type Left, Type Right) : Type;

        public sealed record Nullable(Type Left) : Type;

        public sealed record Iterable(Type? Type) : Type;

        public sealed record Specifier(Type Type) : Type;

        public sealed record Varianced(string? Variance, Type Type) : Type;

        public sealed record Defaulted(Type Type) : Type;

        public sealed record Spread(Type Type) : Type;

        public sealed record Variadic(Type Type, string Op) : Type;

        public sealed record Array(Type Type, NaturalNumber? Size) : Type;

        public sealed record Tuple(Type Type) : Type;

        public sealed record Function(Type Type, Type Arguments) : Type;

        public sealed record CaseType(bool Package, Identifier Name) : Type;

        public sealed record PackageType(TypePath Path) : Type;

        public abstract record List(IEnumerable<Type> Items) : ReadOnlyList<Type>(Items), Type;
    }

    public record TypeList(IEnumerable<Type> Items) : Type.List(Items);

}
