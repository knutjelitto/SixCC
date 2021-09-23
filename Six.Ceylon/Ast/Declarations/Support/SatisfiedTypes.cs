using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class SatisfiedTypes : NodeList<Type>
    {
        public SatisfiedTypes(IEnumerable<Type> items) : base(items)
        {
        }
    }
}
