using Six.Runtime.Types;
using Six.Six.Sema;

namespace Six.Six.Ast
{
    [DebuggerDisplay("{Dbg()}")]
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

        public string Dbg()
        {
            return $"ref {Name} [{this.GetLocation()}]";
        }
    }
}
