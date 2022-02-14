using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Argument : TreeNode
    {
        public sealed record Expression(IRNode Tree, Ast.Expression Expr) : Argument;
        public sealed record Spread(IRNode Tree, Ast.Expression Expr) : Argument;
    }

    public record Arguments(IRNode Tree, IEnumerable<Argument> Items) : Many<Argument>(Tree, Items);
}
