using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Statement : Entity
    {
        A.Statement Ast { get; }

        public static Statement New(A.Statement statement)
        {
            return new Impl(statement);
        }

        private sealed record Impl(A.Statement Ast) : Statement;
    }
}
