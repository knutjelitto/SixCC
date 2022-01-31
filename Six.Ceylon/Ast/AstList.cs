using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface AstList : AstNode
    {
        IEnumerable<AstNode> Items { get; }
    }
}
