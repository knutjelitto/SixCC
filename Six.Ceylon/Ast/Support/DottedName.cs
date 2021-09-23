using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class DottedName : NodeList<Name>
    {
        public DottedName(IEnumerable<Name> names) : base(names)
        {
        }

        public override string ToString()
        {
            return string.Join(".", Items);
        }
    }
}
