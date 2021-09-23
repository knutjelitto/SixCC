using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class IntersectionType : NodeList<Type>, Type
    {
        public IntersectionType(IEnumerable<Type> types) : base(types)
        {
        }
    }
}
