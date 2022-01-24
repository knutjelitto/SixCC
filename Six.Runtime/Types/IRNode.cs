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

        public T? GetValue<T>() where T : class;
    }
}
