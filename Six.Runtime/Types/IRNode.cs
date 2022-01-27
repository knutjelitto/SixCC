using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime.Types
{
    public interface IRNode
    {
        RNode[] Children { get; }

        T? GetValue<T>() where T : class;

        object? Value { get; set; }
    }
}
