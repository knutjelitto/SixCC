using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public sealed record Reference(IRNode Tree, Name Name, GenericArguments? Arguments) : Node
    {
    }
}
