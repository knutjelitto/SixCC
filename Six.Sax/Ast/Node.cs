using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Node
    {
        IRNode Tree { get; }
    }

    public interface NodeList : Node
    {
        IEnumerable<Node> Items { get; }
        int Count { get; }
    }
}
