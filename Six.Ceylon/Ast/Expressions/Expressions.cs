using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Expressions : NodeList<Expression>
    {
        public Expressions(IEnumerable<Expression> items) : base(items)
        {
        }
    }
}
