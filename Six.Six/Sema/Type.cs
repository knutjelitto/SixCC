using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Type
    {
        public Type? Resolved
        {
            get
            {
                if (this is Reference reference)
                {
                    return reference.Type.Resolved;
                }
                else if (this is Type.Alias alias)
                {
                    return alias.Assoc.ResolvedType();
                }
                return this;
            }
        }

        public sealed record Union(params Type[] Types) : Type;
        public sealed record Intersection(params Type[] Types) : Type;
        public sealed record Nothing() : Type;

        public sealed record Classy(Assoc Assoc) : Entity, Type;
        public sealed record Alias(Assoc Assoc) : Entity, Type;

        public Type UnionWith(Type? type)
        {
            if (type != null)
            {
                return new Union(this, type);
            }
            return this;
        }

        public Type IntersectionWith(Type? type)
        {
            if (type != null)
            {
                return new Intersection(this, type);
            }
            return this;
        }
    }
}
