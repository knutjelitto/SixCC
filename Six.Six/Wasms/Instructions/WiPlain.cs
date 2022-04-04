using Six.Runtime;
using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WiPlain : WaInstruction
    {
        protected WiPlain(IWithWriter withWriter)
            : base(withWriter)
        {
        }

        public override void Emit()
        {
            wl($"{this}");
        }
    }

    public class WiInsn : WiPlain
    {
        public WiInsn(IWithWriter withWriter, Insn insn)
            : base(withWriter)
        {
            Insn = insn;
        }

        public Insn Insn { get; }

        public override string ToString()
        {
            return Insn.ToString()!;
        }
    }
}
