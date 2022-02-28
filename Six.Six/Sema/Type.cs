using Six.Six.Builtins;

namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        public interface Declared : Type
        {
            Decl Decl { get; }
        }

        public sealed record BuiltinReference(Builtin Builtin) : Type;

        public sealed record Reference(Decl Decl) : Declared;

        public sealed record Callable(Decl Decl, Type Result, params Type[] Parameters) : Declared;

        public sealed record Tuple(params Type[] Types) : Type;
    }
}
