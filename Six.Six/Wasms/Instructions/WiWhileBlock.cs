using Six.Runtime;
using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public sealed class WiWhileBlock : WiBlock
    {
        public WiWhileBlock(IWithWriter withWriter, WasmType? type, WaInstructionList condition, WaInstructionList body)
            : base(withWriter)
        {
            Type = type;
            Condition = condition;
            Body = body;
        }

        public WasmType? Type { get; }
        public WaInstructionList Condition { get; }
        public WaInstructionList Body { get; }

        public override void Emit()
        {
            var wLabel = $"break";
            var lLabel = $"continue";

            wl($"{Insn.Block} ${wLabel}");
            indent(() =>
            {
                var result = Type == null ? "(result)" : $"(result {Type})";

                wl($"{Insn.Loop} ${lLabel}");
                indent(() =>
                {
                    Condition.Emit();
                    wl($"{Insn.U32.EQZ}");
                    wl($"{Insn.BrIf(wLabel)}");
                    wl(";; -----");
                    Body.Emit();
                    wl(";; -----");
                    wl($"{Insn.Br(lLabel)}");
                });
                wl($"{Insn.End}");
            });
            wl($"{Insn.End}");
        }
    }
}
