using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class ArgumentList : NodeList<Argument>
    {
        public ArgumentList(IEnumerable<Argument> values) : base(values)
        {
        }
    }
}
