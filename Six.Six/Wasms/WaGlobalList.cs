using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public class WaGlobalList : WaListOf<WaGlobal>
    {
        public WaGlobalList(WaModule module)
            : base(module)
        {
            Module = module;
        }

        public WaModule Module { get; }
    }
}
