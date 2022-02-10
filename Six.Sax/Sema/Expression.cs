using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Expression : Entity
    {
        A.Expression Ast { get; }

        public static Expression New(A.Expression expression)
        {
            return new Impl(expression);
        }

        private sealed record Impl(A.Expression Ast) : Expression;
    }
}
