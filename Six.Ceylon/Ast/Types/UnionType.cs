using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class UnionType : NodeList<Type>, Type
    {
        public UnionType(IEnumerable<Type> types) : base(types)
        {
        }
    }
}
