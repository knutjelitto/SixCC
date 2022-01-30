using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public interface CaseItem
    {
        public sealed record IsCase(Typo Type) : CaseItem;
    }
}
