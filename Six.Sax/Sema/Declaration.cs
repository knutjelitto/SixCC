using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Declaration : Entity, Named
    {
        public sealed record Function(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Class(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Attribute(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Object(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Interface(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Alias(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Parameter(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record TypeParameter(A.TreeNode Ast, Container Container) : Declaration;
        public sealed record Any(A.TreeNode Ast, Container Container) : Declaration;
    }
}
