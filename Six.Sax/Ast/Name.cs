using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public sealed record Name(IRNode Tree) : Node, Expression;
    public sealed record Names(IRNode Tree, IEnumerable<Name> Items) : Many<Name>(Tree, Items);
}
