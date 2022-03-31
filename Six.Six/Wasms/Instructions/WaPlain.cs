using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WaPlain : WaInstruction
    {
        protected WaPlain(WaFunction function)
            : base(function)
        {
        }
    }
}
