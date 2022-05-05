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

            ObjectId = Module.NextObjectId++;
        }

        public uint ObjectId { get; }
        public WaStringData StringData { get; }
        public WaModule Module => StringData.Module;
        public int Order { get; }
        public string Text { get; }
        public byte[] Bytes { get; }
        public uint PayloadSize => (uint)Bytes.Length;
        public uint Size => WasmType.Addr.MemSize + WasmType.I32.MemSize + WasmType.I32.MemSize + PayloadSize;

        public WaPtr Address { get; set; } = WaPtr.Invalid;
        public WaPtr NextAddress { get; set; } = WaPtr.Invalid;
        public WaPtr Payload => Address.Offset(WaRunType.HeaderSize);

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
            wl($"(; ???            ;) {Data.EmitInt32(-1)}");
            wl($"(; object-id {ObjectId,4} ;) {Data.EmitUInt32(ObjectId)}");
            wl($"(; dispatch       ;) {Data.EmitInt32(meta.Dispatches.Index)}");
            wl($"(; payload-size   ;) {Data.EmitUInt32(PayloadSize)}");
            wl($"(; +{WaRef.PayloadOffset,2}            ;)");
            wl($"(; name      {Bytes.Length,4} ;) {Data.EmitUtf8(Bytes)}");
            wl($"(; fill      {missing,4} ;){fill}");
            wl($"(; +{(NextAddress.Address - Address.Address),2}            ;)");
        }
    }
}
