using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public sealed record Path(IRNode Tree, IEnumerable<Reference> Items) : Many<Reference>(Tree, Items), Type;
}
