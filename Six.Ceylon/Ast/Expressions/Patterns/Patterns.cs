using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Patterns : NodeList<Pattern>
    {
        public Patterns(IEnumerable<Pattern> items) : base(items)
        {
        }
    }
}
