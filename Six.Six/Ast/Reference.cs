using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public sealed record Reference(IRNode Tree, Name Name, Generic.TypeArguments? Arguments)
        : Expression, Type
    {
        public Reference(RLiteral literal) : this(literal, new Name.Id(literal), null)
        {
        }
    }
}
