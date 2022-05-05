using Six.Runtime;
using Data = Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaRunType : WithWriter, Wamber
    {
        public static readonly uint HeaderSize = WasmType.I32.Size +  WasmType.Addr.Size + WasmType.I32.Size + WasmType.I32.Size;

        public struct PayloadLayout
        {
            /* + 0 */ public readonly WaPtr Name;
            /* + 4 */ public readonly uint Size;
            /* + 8 */ public readonly uint Dispatch;
        }

        public WaRunType(WaClass clazz)
            : base(clazz.Writer)
        {
            Class = clazz;
            Module = clazz.Module;
            ObjectId = Module.NextObjectId++;
        }

        public WaClass Class { get; }
        public WaModule Module { get; }
        public uint ObjectId { get; }

        public WaPtr StartAddress { get; set; } = WaPtr.Invalid;
        public WaPtr Content => StartAddress.Offset(WaRef.HeaderSize);
        public WaPtr NextAddress { get; set; } = WaPtr.Invalid;

        public unsafe uint PayloadSize => (uint)sizeof(PayloadLayout);
        public uint Size => HeaderSize + PayloadSize;

        public void Prepare()
        {
            Assert(StartAddress.IsValid);
            Assert(NextAddress.IsValid);
            Assert(NextAddress > StartAddress);
        }

        public void Emit()
        {
            var reference = WaRef.FromHeaderAddress(StartAddress);

            Assert(WaRef.HeaderSize == HeaderSize);

            wl($"(; class {Class.Name} ;)");
            indent(() =>
            {
                var meta = Module.MetaClass;

                var dispatch = Class.Dispatches.Count > 0 ? Class.Dispatches.Index : -1;

                var missing = NextAddress - StartAddress - Size;
                var fill = missing > 0 ? $" {Data.EmitZeros(missing)}" : "";

                wl($"(; {reference.Header} ;)");
                wl($"(; ???            ;) {Data.EmitInt32(-1)}");
                wl($"(; object-id {ObjectId,4} ;) {Data.EmitUInt32(ObjectId)}");
                wl($"(; dispatch       ;) {Data.EmitInt32(meta.Dispatches.Index)}");
                wl($"(; payload-size   ;) {Data.EmitUInt32(PayloadSize)}");
                wl($"(; {reference.Payload} ;)");
                wl($"(; name           ;) {Data.EmitPtr(Class.NameConst.Address)}");
                wl($"(; size           ;) {Data.EmitUInt32(Class.FieldsSize)}");
                wl($"(; dispatch {dispatch,5} ;) {Data.EmitInt32(dispatch)}");
                wl($"(; align-fill     ;){fill}");
            });
        }
    }
}
