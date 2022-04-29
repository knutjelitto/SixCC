using Six.Runtime;
using static Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaStaticField : WaField
    {
        public WaStaticField(IWithWriter withWriter, string name, WasmType type)
            : base(withWriter, name, type)
        {
            Instructions = new WaInstructionList(withWriter);
        }

        public WaPtr Address { get; set; } = WaPtr.Invalid;
        public uint Size => Type.MemSize;
        public WaInstructionList Instructions { get; }

        public override void Prepare()
        {
            Assert(Address.IsValid);
        }

        public override void Emit()
        {
            wl($"(; {Address} {Name} ;) {EmitZeros(Size)}");
        }

        public void EmitAddress()
        {
            Address.EmitAddress(Writer);
        }
    }
}
