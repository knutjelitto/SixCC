using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public sealed record Prelude(IRNode Tree, Expression.String? Doc, Attributes Attributes) : TreeNode;
    public sealed record Attribute(IRNode Tree, RToken Name, Arguments? Arguments) : TreeNode;
    public sealed record Attributes(IRNode Tree, IEnumerable<Attribute> Items) : Many<Attribute>(Tree, Items);
}
