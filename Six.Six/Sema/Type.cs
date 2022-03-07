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

        public sealed record Callable(Resolver Resolver, Decl Decl, Type Result, List<Type> Parameters) : Declared
        {
            public Callable(Resolver Resolver, Decl Decl, Type Result, params Type[] Params)
                : this(Resolver, Decl, Result, Params.ToList())
            { }
        }

        public sealed record Tuple(Resolver Resolver, params Type[] Types) : TypeImpl(Resolver);

        public sealed record Array(Resolver Resolver, Type Type) : TypeImpl(Resolver);
        public abstract record TypeImpl(Resolver Resolver) : Type;
    }
}
