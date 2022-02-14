using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Statement : Entity
    {
        public interface Block : Entity
        {
            public static Block New(A.Body body, Container container) => new Impl(body, container);
            private sealed record Impl(A.TreeNode Ast, Container Container) : Block;
        }

        public static Statement New(A.Statement statement, Container container) => new Impl(statement, container);
        private sealed record Impl(A.TreeNode Ast, Container Container) : Statement;
    }
}
