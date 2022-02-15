using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Type
    {
        public record Reference(Entity Entity, params Type[] Arguments) : Type;
        public sealed record Sequential(Entity Entity, params Type[] Arguments) : Reference(Entity, Arguments);
        public sealed record Sequence(Entity Entity, params Type[] Arguments) : Reference(Entity, Arguments);

        public record Union(params Type[] Types) : Type;
        public sealed record Defaulted(Reference Empty, Type Type) : Union(Empty, Type);
        public sealed record Intersection(params Type[] Types) : Type;
        public sealed record Nothing() : Type;

        public sealed record Variadic(Reference Type) : Type;
    }
}
