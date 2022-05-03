using Six.Runtime;

using Data = Six.Six.Wasms.WasmData;

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
        public uint PayloadSize => (uint)Bytes.Length;
        public uint Size => WasmType.Addr.MemSize + WasmType.I32.MemSize + WasmType.I32.MemSize + PayloadSize;

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

            var missing = NextAddress - Address - WaRef.HeaderSize - PayloadSize;
            var fill = missing > 0 ? $" {Data.EmitZeros(missing)}" : "";

            wl($"(; {Address} ;)");
            wl($"(; heap           ;) {Data.EmitInt32(-1)}");
            wl($"(; clazz          ;) {Data.EmitPtr(meta.RuntimeType.Address)}");
            wl($"(; clazz-dispatch ;) {Data.EmitInt32(meta.Dispatches.Index)}");
            wl($"(; size           ;) {Data.EmitUInt32(PayloadSize)}");
            wl($"(; +{WaRef.PayloadOffset,2}            ;)");
            wl($"(; name           ;) {Data.EmitUtf8(Bytes)}");
            wl($"(; align-fill     ;){fill}");
            wl($"(; +{(NextAddress.Address - Address.Address),2}            ;)");
        }
    }
}
