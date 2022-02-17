using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Statement : Entity, WithContainer
    {
        public interface Block : Entity, WithContainer
        {
            public static Block New(A.Body body, Container container) => new Impl(body, container);
            private sealed record Impl(A.TreeNode Ast, Container Container) : Block;
        }

        public static Statement New(A.Statement statement, Container container) => new Impl(statement, container);
        private sealed record Impl(A.TreeNode Ast, Container Container) : Statement;
    }
}
