using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WiPlain : WaInstruction
    {
        protected WiPlain(WaFunction function)
            : base(function)
        {
        }

        public override void Emit()
        {
            wl($"{this}");
        }
    }

    public class WiInsn : WiPlain
    {
        public WiInsn(WaFunction function, Insn insn)
            : base(function)
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
