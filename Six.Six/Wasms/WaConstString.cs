using Six.Runtime;

using Data = Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaConstString : WaObject
    {
        public WaConstString(WaStringData stringData, int order, string text)
            : base(stringData.Module)
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
        public override uint PayloadSize => (uint)Bytes.Length;
        public uint Size => WasmType.Addr.MemSize + WasmType.I32.MemSize + WasmType.I32.MemSize + PayloadSize;
        public override WaClass Meta => StringData.Module.StringClass;

        public override void Emit()
        {
            var missing = NextAddress - StartAddress - WaRef.HeaderSize - PayloadSize;
            var fill = missing > 0 ? $" {Data.EmitZeros(missing)}" : "";

            EmitHeader();

            wl($"(; {ObjectAddress} ;)");
            indent(() =>
            {
                wl($"(; name      {Bytes.Length,4} ;) {Data.EmitUtf8(Bytes)}");
            });

            if (missing > 0)
            {
                wl($"{Data.EmitZeros(missing)} ;; padding");
            }
        }
    }
}
