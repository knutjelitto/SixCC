using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WaBlock : WaInstruction
    {
        protected WaBlock(WaFunction function)
            : base(function)
        {
        }
    }
}
