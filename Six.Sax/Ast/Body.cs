using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Body : Expression
    {
        public sealed record Null(IRNode Tree) : Body;

        public sealed record Function(IRNode Tree, Expression Expression) : Body;

        public sealed record Block(IRNode Tree, Declarations Declarations, Statements Statements) : Body;
    }
}
