using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public sealed record Path(IRNode Tree, IEnumerable<Reference> Items) : Many<Reference>(Tree, Items), Type;
}
