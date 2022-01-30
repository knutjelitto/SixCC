using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed record ResourceList(IEnumerable<Resource> resources)
        : ReadOnlyList<Resource>(resources.ToList());
}
