using Six.Runtime;

using static Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaConstString : WithWriter, Wamber
    {
        public WaConstString(WaStringData stringData, int order, string text)
            : base(stringData.Writer)
        {
            StringData = stringData;
            Order = order;
            Text = text;

            Bytes = Encoding.UTF8.GetBytes(Text);
        }

        public WaStringData StringData { get; }
        public int Order { get; }
        public string Text { get; }
        public byte[] Bytes { get; }
        public uint Count => (uint)Bytes.Length;
        public uint Size => WasmType.Addr.MemSize + WasmType.I32.MemSize + WasmType.I32.MemSize + Count;

        public WaPtr Address { get; set; } = WaPtr.Invalid;
        public WaPtr NextAddress { get; set; } = WaPtr.Invalid;
        public WaPtr Payload => Address.Offset(WaRuntime.PayloadOffset);

        public void Prepare()
        {
            Assert(Address.IsValid);
            Assert(NextAddress.IsValid);
            Assert(Address < NextAddress);
        }

        public void Emit()
        {
            var missing = NextAddress - Address - Size;
            var fill = missing > 0 ? $" {EmitZeros(missing)}" : "";

            var classAddress = StringData.Module.StringClass.RuntimeType.Address;
            var classDispatch = (uint)StringData.Module.StringClass.Dispatches.Index;

            wl($"(; +{Address.Address,4} 0x{Address.Address:X4} ;) {EmitUInt32(classAddress)} {EmitUInt32(classDispatch)} {EmitUInt32(Count)} {EmitUtf8(Bytes)}{fill}");
        }
    }
}
