using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Anything : Builtin
    {
        public Anything(Builtins builtins)
            : base(builtins, Names.Core.Anything)
        { }

        public override string AsWasm => $"i32";

        public override string ToString() => Name;
    }
}
