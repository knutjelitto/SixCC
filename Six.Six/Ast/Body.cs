using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public interface Body : Expression
    {
        public sealed record Deferred(IRNode Tree) : Body;
        public sealed record Builtin(IRNode Tree) : Body;
        public sealed record Value(IRNode Tree, Expression Expression) : Body;
        public sealed record Block(IRNode Tree, Usings Usings, Statelarations Statelarations) : Body;
    }
}
