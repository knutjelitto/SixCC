using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Body : Expression
    {
        public sealed record Deferred(IRNode Tree) : Body;
        public sealed record Builtin(IRNode Tree) : Body;
        public sealed record Value(IRNode Tree, Expression Expression) : Body;
        public sealed record Block(IRNode Tree, Usings Usings, Statelarations Statelarations) : Body;

        public sealed record Class(IRNode Tree, Block Block) : Body;
        public sealed record Interface(IRNode Tree, Block Block) : Body;
    }
}
