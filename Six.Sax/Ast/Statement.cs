using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Statement : TreeNode, Statelaration
    {
        public sealed record Return(IRNode Tree, Expression? Expression) : Statement;
        public sealed record Assert(IRNode Tree, Expression.Literal.String? Message, Arguments Arguments) : Statement;
    }
}
