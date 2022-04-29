using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public sealed class WiGetRuntimeType : WaInstruction
    {
        public WaClass Class { get; }

        public WiGetRuntimeType(WaClass @class)
            : base(@class)
        {
            Class = @class;
        }

        public override void Emit()
        {
            var address = Class.RuntimeType.Address;
            Assert(address.IsValid);

            wl($"{Insn.U32.Const(address.Address)}");
        }
    }
}
