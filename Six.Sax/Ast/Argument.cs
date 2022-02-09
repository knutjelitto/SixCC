using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Argument : TreeNode {}

    public record Arguments(IRNode Tree, IEnumerable<Argument> Items) : Many<Argument>(Tree, Items);
}
