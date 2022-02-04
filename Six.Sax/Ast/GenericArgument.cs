using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public record GenericArgument(IRNode Tree, Type Expression) : Node;

    public record GenericArguments(IRNode Tree, IEnumerable<GenericArgument> Items) : Many<GenericArgument>(Tree, Items);
}
