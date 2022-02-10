using Six.Runtime.Types;

namespace Six.Sax.Ast
{
    public interface Body : Expression
    {
        public sealed record Deferred(IRNode Tree) : Body;

        public sealed record Block(IRNode Tree, Statelarations Statelarations) : Body;
    }
}
