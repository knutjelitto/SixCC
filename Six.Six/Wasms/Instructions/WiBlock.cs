using Six.Runtime;
using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WiBlock : WaInstruction
    {
        protected WiBlock(IWithWriter withWriter)
            : base(withWriter)
        {
        }
    }

    public sealed class WiIfBlock : WiBlock
    {
        public WiIfBlock(IWithWriter withWriter, WasmType type, WaInstructionList condition, WaInstructionList then, WaInstructionList? @else)
            : base(withWriter)
        {
            Type = type;
            Condition = condition;
            Then = then;
            Else = @else;
        }

        public WasmType Type { get; }
        public WaInstructionList Condition { get; }
        public WaInstructionList Then { get; }
        public WaInstructionList? Else { get; }

        public override void Emit()
        {
            Condition.Emit();
            wl($"{Insn.If} (result {Type})");
            indent(() => Then.Emit());
            if (Else != null)
            {
                wl($"{Insn.Else}");
                indent(() => Else.Emit());
            }
            wl($"{Insn.End}");
        }
    }
}
