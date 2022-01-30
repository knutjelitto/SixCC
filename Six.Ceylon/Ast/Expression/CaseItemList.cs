using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public record CaseItemList(IEnumerable<CaseItem> items)
        : ReadOnlyList<CaseItem>(items.ToList()), CaseItem;
}
