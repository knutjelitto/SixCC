using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Statement : Node
    {
        public sealed record Return(IRNode Tree, Expression? Expression) : Statement;
        public sealed record Assert(IRNode Tree, Expression.Literal.String? Message, Arguments Arguments) : Statement;
    }

    public sealed record Statements(IRNode Tree, IEnumerable<Statement> Items) : Many<Statement>(Tree, Items);
}
