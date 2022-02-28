using Six.Runtime.Types;

namespace Six.Six.Ast
{
    public sealed record Reference(IRNode Tree, Name Name, TypeArguments? Arguments)
        : Expression, Type
    {
        public Reference(RLiteral literal) : this(literal, new Name.Id(literal), null)
        {
        }

        public override string ToString()
        {
            return Name.Text;
        }
    }
}
