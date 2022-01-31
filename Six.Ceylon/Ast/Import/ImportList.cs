using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed record ImportList(IEnumerable<Import> Items) : ReadOnlyList<Import>(Items);
}
