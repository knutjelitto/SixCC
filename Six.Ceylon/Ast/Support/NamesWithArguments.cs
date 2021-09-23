using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class NamesWithArguments : NodeList<NameWithArguments>
    {
        public NamesWithArguments(IEnumerable<NameWithArguments> items) : base(items)
        {
        }
    }
}
