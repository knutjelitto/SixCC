using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Expression : Node, Argument
    {
        public record String(IRNode Tree) : Expression;

        public sealed record Add(IRNode Tree, Expression Left, Expression Right) : Expression;
    }
}
