using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Expression : Entity
    {
        public static Expression New(A.Expression expression, Container container)
            => new Impl(expression, container);
        private sealed record Impl(A.TreeNode Ast, Container Container) : Expression;
    }
}
