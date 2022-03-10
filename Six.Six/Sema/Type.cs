namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        public interface Declared : Type
        {
            Decl Decl { get; }
        }

        public interface Builtin : Type
        {
        }

        [DebuggerDisplay("reference <{Decl}>")]
        public sealed record Reference(Decl Decl) : Declared
        {
        }

        public sealed record Callable(Type Result, List<Type> Parameters) : Type
        {
            public Callable(Type Result, params Type[] Params)
                : this(Result, Params.ToList())
            { }
        }

        public sealed record Tuple(params Type[] Types) : TypeImpl;

        public sealed record Array(Type Type) : TypeImpl;
        public abstract record TypeImpl : Type;
    }
}
