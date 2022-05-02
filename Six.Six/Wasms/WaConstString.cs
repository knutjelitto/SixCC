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
        public WaPtr Payload => Address.Offset(WaRuntime.HeaderSize);

        public void Prepare()
        {
            Assert(Address.IsValid);
            Assert(NextAddress.IsValid);
            Assert(Address < NextAddress);
        }

        public void Emit()
        {
            var meta = StringData.Module.StringClass;

            var dispatch = (uint)meta.Dispatches.Index;

            var missing = NextAddress - Address - Size;
            var fill = missing > 0 ? $" {EmitZeros(missing)}" : "";

            var classAddress = meta.RuntimeType.Address.Address;


            wl($"(; {Address} ;) {EmitPtr(meta.RuntimeType.Address)} {EmitUInt32(dispatch)} {EmitUInt32(Count)} {EmitUtf8(Bytes)}{fill}");
        }
    }
}
