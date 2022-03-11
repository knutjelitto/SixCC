using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Boolean : Builtin
    {
        public Boolean()
            : base(Names.Core.Boolean)
        { }

        public override string AsWasm => $"i32";
    }
}
