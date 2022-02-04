using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public sealed record Prelude(IRNode Tree, Expression.String? Doc, Attributes Attributes) : Node;
    public sealed record Attribute(IRNode Tree, Name Name, Arguments? Arguments) : Node;
    public sealed record Attributes(IRNode Tree, IEnumerable<Attribute> Items) : Many<Attribute>(Tree, Items);
}
