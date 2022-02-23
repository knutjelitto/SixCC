using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }

        A.Name Name => ADecl.Name;
    }

    public record Declaration(Scope Container, A.Decl ADecl) : Decl;
}
