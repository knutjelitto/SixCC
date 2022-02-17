using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Expression
    {
        A.TreeNode Ast { get; }
        //public Type Type { get; }
        //public Action Builder { get; }

        public record Prefix(A.TreeNode Ast, Expression Expr) : Expression;
        public record Infix(A.TreeNode Ast, Expression Left, Expression Right) : Expression;

        public record Call(A.TreeNode Ast, Expression Expr, params Expression[] Arguments) : Expression;

        public record NaturalLiteral(A.TreeNode Ast, Type Type, ulong Value) : Expression;
    }
}
