using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Members : NodeList<Member>
    {
        public Members(IEnumerable<Member> items) : base(items)
        {
        }
    }

    public interface Member : INode
    {
    }
}
