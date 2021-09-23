using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class ValueCase : NodeList<Expression>, ConditionForCase
    {
        public ValueCase(IEnumerable<Expression> items) : base(items)
        {
        }
    }
}
