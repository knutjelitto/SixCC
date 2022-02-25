namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        Decl Decl { get; }
        
        public sealed record Reference(Decl Decl) : Type;

        public sealed record Callable(Decl Decl, Type Result, params Type[] Parameters) : Type;
    }
}
