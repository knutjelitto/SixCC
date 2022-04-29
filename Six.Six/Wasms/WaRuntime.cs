using Six.Runtime;
using Data = Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaRuntime : WithWriter, Wamber
    {
        public static readonly uint HeaderSize = WasmType.Addr.Size + WasmType.I32.Size;
        public static readonly uint PayloadSize = WasmType.I32.Size + WasmType.Addr.Size + WasmType.I32.Size;

        public WaRuntime(WaClass clazz)
            : base(clazz.Writer)
        {
            Class = clazz;
            Module = clazz.Module;
        }

        public WaClass Class { get; }
        public WaModule Module { get; }

        public WaPtr Address { get; set; } = WaPtr.Invalid;
        public WaPtr NextAddress { get; set; } = WaPtr.Invalid;
        public WaPtr Payload => Address.Offset(HeaderSize);
        public uint Size => HeaderSize + PayloadSize;

        public void Prepare()
        {
            Assert(Address.IsValid);
            Assert(NextAddress.IsValid);

            Assert(NextAddress > Address);
        }

        public void Emit()
        {
            wl($"(; {Address} - {Class.Name} ;)");
            indent(() =>
            {
                var dispatch = Class.Dispatches.Count > 0 ? Class.Dispatches.Index : -1;
                var missing = NextAddress - Address - Size;
                var fill = missing > 0 ? $" {Data.EmitZeros(missing)}" : "";


                wl($"(; clazz          ;) {Data.EmitUInt32(Module.MetaClass.RuntimeType.Address.Address)}");
                wl($"(; clazz-dispatch ;) {Data.EmitUInt32((uint)Module.MetaClass.Dispatches.Index)}");
                wl($"(; {Address.Offset(HeaderSize)} ;)");
                wl($"(; size           ;) {Data.EmitUInt32(8 + Class.FieldsSize)}");
                wl($"(; name           ;) {Data.EmitAddress(Class.NameConst.Address.Address)}");
                wl($"(; dispatch {dispatch,5} ;) {Data.EmitInt32(dispatch)}");

                wl($"(; fill           ;){fill}");

            });
        }
    }
}
