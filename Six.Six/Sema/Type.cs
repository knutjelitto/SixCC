using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Type
    {
        public sealed record Union(params Type[] Types) : Type;
        public sealed record Intersection(params Type[] Types) : Type;
        public sealed record Nothing() : Type;

        public Type? UnionWith(Type? type)
        {
            if (type != null)
            {
                return new Union(this, type);
            }
            return null;
        }
    }
}
