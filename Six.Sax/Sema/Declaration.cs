using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Declaration : Entity, Named
    {
        public sealed record Function(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Class(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Attribute(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Object(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Interface(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Alias(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Parameter(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record TypeParameter(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);
        public sealed record Any(A.TreeNode Ast, Container Container) : DeclarationImpl(Ast, Container);

        public abstract record DeclarationImpl(A.TreeNode Ast, Container Container) : Declaration
        {
            public override string ToString()
            {
                return $"{GetType().Name} {((Entity)this).Name}";
            }
        }

    }
}
