using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms.Instructions
{
    public class WiAdd : WaInstruction
    {
        public WiAdd(IWithWriter withWriter) : base(withWriter)
        {
        }

        public override void Emit()
        {
            throw new NotImplementedException();
        }
    }
}
