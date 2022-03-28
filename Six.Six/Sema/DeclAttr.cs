using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    [Flags]
    public enum DeclAttr
    {
        None = 0,
        Native = 1 << 0,
        Shared = 1 << 1,
        Static = 1 << 2,
        Abstract = 1 << 3,
        Virtual = 1 << 4,
        Override = 1 << 5,
        Sealed = 1 << 6,
    }
}
