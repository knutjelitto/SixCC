using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Bytes : Builtin
    {
        public Bytes(Builtins builtins)
            : base(builtins, Names.Core.Bytes)
        { }

        public override string AsWasm => $"i32";
    }
}
