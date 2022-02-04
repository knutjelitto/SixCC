using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Type : Node
    {
    }

    public sealed record Types(IRNode Tree, IEnumerable<Type> Items) : Many<Type>(Tree, Items);
}
