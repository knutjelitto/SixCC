using Six.Runtime;
using Data = Six.Six.Wasms.WasmData;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Wasms
{
    public class WaRunType : WaObject
    {
        public static readonly uint HeaderSize = WasmType.I32.Size +  WasmType.Addr.Size + WasmType.I32.Size + WasmType.I32.Size;

        public struct PayloadLayout
        {
            /* + 0 */ public readonly WaPtr Name;
            /* + 4 */ public readonly uint Size;
            /* + 8 */ public readonly uint Dispatch;
        }

        public WaRunType(WaClass clazz)
            : base(clazz.Module)
        {
            Class = clazz;
        }

        public WaClass Class { get; }

        public unsafe override uint PayloadSize => (uint)sizeof(PayloadLayout);
        public uint Size => HeaderSize + PayloadSize;

        public override WaClass Meta => Module.MetaClass;

        public override void Emit()
        {
            var reference = WaRef.FromObjectAddress(ObjectAddress);

            Assert(WaRef.HeaderSize == HeaderSize);

            wl($"(; class {Class.Name} ;)");
            indent(() =>
            {
                var dispatch = Class.Dispatches.Count > 0 ? Class.Dispatches.Index : -1;

                var missing = NextAddress - StartAddress - Size;
                var fill = missing > 0 ? $"{Data.EmitZeros(missing)} ;; padding" : "";

                EmitHeader();

                wl($"(; {ObjectAddress} ;)");
                indent(() =>
                {
                    wl($"(; name           ;) {Data.EmitPtr(Class.NameConst.ObjectAddress)}");
                    wl($"(; size           ;) {Data.EmitUInt32(Class.FieldsSize)}");
                    wl($"(; dispatch {dispatch,5} ;) {Data.EmitInt32(dispatch)}");
                });

                if (missing > 0)
                {
                    wl($"{Data.EmitZeros(missing)} ;; padding");
                }
            });
        }
    }
}
