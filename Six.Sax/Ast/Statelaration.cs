using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Statelaration : Node
    {
    }

    public sealed record Statelarations(IRNode Tree, IEnumerable<Statelaration> Items)
        : Many<Statelaration>(Tree, Items);
}
