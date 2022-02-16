using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Type
    {
        public record Reference(Declarations Declarations, params Type[] Arguments) : Type;

        public record Union(params Type[] Types) : Type;
        public sealed record Defaulted(Reference Empty, Type Type) : Union(Empty, Type);
        public sealed record Intersection(params Type[] Types) : Type;
        public sealed record Nothing() : Type;

        public sealed record Variadic(Reference Type) : Type;
    }
}
