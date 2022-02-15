using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Argument : TreeNode
    {
        public sealed record Spread(IRNode Tree, Expression Expr) : Argument;
    }

    public record Arguments(IRNode Tree, Expressions Listed, Argument? Final) : TreeNode;
}
