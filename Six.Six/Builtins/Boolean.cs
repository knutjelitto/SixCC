using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Boolean : Builtin
    {
        public override string AsWasm => $"i32";
    }
}
