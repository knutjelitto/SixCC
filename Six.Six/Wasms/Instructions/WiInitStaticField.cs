using Six.Six.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms.Instructions
{
    public sealed class WiInitStaticField : WaInstruction
    {
        public WiInitStaticField(WaStaticField field)
            : base(field)
        {
            Field = field;
        }

        public WaStaticField Field { get; }

        public override void Emit()
        {
            Assert(Field.Address.IsValid);

            Field.EmitAddress();
            foreach (var insn in Field.Instructions)
            {
                wl($"{insn}");
            }
            wl($"{Insn.Address.Store(0)}");
        }
    }
}
