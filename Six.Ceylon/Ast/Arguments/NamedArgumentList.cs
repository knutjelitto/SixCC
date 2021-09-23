using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class NamedArgumentList : NodeList<NamedArgument>
    {
        public NamedArgumentList(IEnumerable<NamedArgument> arguments) : base(arguments)
        {
        }
    }
}
