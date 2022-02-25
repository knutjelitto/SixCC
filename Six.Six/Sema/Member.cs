using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Member : Entity
    {
        Scope Container { get; }
    }
}
