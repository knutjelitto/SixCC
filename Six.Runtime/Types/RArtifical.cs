using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime.Types
{
    public class RArtifical : IRNode
    {
        public RNode[] Children { get; } = Array.Empty<RNode>();

        public object? Value { get; set; }

        public T? GetValue<T>() where T : class
        {
            return null;
        }
    }
}
