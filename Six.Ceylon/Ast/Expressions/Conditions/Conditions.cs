using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Conditions : NodeList<Condition>
    {
        public Conditions(IEnumerable<Condition> items) : base(items)
        {
        }
    }

    public interface Condition : INode
    {
    }
}
