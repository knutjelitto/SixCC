using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WiBlock : WaInstruction
    {
        protected WiBlock(WaFunction function)
            : base(function)
        {
        }
    }

    public sealed class WiIfBlock : WiBlock
    {
        public WiIfBlock(WaFunction function, WasmType type, WaInstructionList condition, WaInstructionList then, WaInstructionList @else)
            : base(function)
        {
            Type = type;
            Condition = condition;
            Then = then;
            Else = @else;
        }

        public WasmType Type { get; }
        public WaInstructionList Condition { get; }
        public WaInstructionList Then { get; }
        public WaInstructionList Else { get; }

        public override void Emit()
        {
            Condition.Emit();
            wl($"{Insn.If} (result {Type})");
            indent(() => Then.Emit());
            wl($"{Insn.Else}");
            indent(() => Else.Emit());
            wl($"{Insn.End}");
        }
    }
}
