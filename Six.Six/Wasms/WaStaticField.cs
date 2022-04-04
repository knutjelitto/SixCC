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

        public uint Address { get; set; } = uint.MaxValue;
        public uint Size => Type.MemSize;
        public WaInstructionList Instructions { get; }

        public override void Prepare()
        {
            Assert(Address < uint.MaxValue);
        }

        public override void Emit()
        {
            wl($"(; +{Address,4} 0x{Address:X4} {Name} ;) {EmitZeros(Type.MemSize)}");
        }
    }
}
