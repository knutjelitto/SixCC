namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        public sealed record Reference(Decl Decl) : Type;

        public sealed record Callable(Decl Decl, Type Result, params Type[] Parameters) : Type;
    }
}
