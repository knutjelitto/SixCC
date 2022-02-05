using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public record Namespace(IRNode Tree, Prelude Prelude, Names Names, Declarations Declarations) : Node;
}
