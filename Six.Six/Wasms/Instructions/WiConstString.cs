using Six.Runtime;
using Six.Six.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms.Instructions
{
    public sealed class WiConstString : WaInstruction
    {
        public WiConstString(WaConstString constString)
            : base(constString)
        {
            ConstString = constString;
        }

        public WaConstString ConstString { get; }

        public override void Prepare()
        {
        }

        public override void Emit()
        {
            Assert(ConstString.ObjectAddress.IsValid);

            wl($"{Insn.U32.Const(ConstString.ObjectAddress.Address)}");
        }
    }
}
