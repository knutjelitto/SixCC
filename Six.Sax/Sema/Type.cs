using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Type
    {
        public sealed record Reference(Entity Entity, params Type[] Arguments) : Type;
        public sealed record Union(params Type[] Types) : Type;
        public sealed record Intersection(params Type[] Types) : Type;
        public sealed record Nothing() : Type;

        public sealed record Variadic(Reference type) : Type;
    }
}
