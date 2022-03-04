namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        Resolver Resolver { get; }

        public interface Declared : Type
        {
            Decl Decl { get; }
        }

        public interface Builtin : Type
        {
        }

        public sealed record Reference(Resolver Resolver, Decl Decl) : Declared;

        public sealed record Callable(Resolver Resolver, Decl Decl, Type Result, params Type[] Parameters) : Declared;

        public sealed record Tuple(Resolver Resolver, params Type[] Types) : TypeImpl(Resolver);

        public abstract record TypeImpl(Resolver Resolver) : Type;
    }
}
