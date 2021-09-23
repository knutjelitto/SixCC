using System.Collections.Generic;
using System.Linq;

namespace Six.Ceylon.Ast
{
    public abstract class NodeList<T> : Node
        where T : INode
    {
        public NodeList(IEnumerable<T> items)
        {
            Items = items.ToList();
        }

        public List<T> Items { get; }
    }
}
