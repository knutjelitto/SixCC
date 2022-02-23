using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }

        A.Name Name => ADecl.Name;

        Props Props { get; }
    }

    public record Declaration(Scope Container, A.Decl ADecl) : Decl
    {
        public Props Props { get; } = new Props();
    }

    public static class DeclExtensions
    {
        public static Type? Result(this Decl decl)
        {
            return decl.Props.Get<Type>(nameof(Result));
        }
        public static bool Result(this Decl decl, Type type)
        {
            return decl.Props.TrySet(nameof(Result), type);
        }
    }

}
