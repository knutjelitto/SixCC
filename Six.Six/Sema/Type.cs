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

        public sealed record Reference(Decl Decl) : Declared;

        public sealed record Callable(Decl Decl, Type Result, params Type[] Parameters) : Declared;

        public sealed record Tuple(params Type[] Types) : Type;
    }
}
