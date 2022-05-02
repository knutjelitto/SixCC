﻿using Six.Runtime;
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
            var reference = new WaRef(Address);

            Assert(WaRef.HeaderSize == HeaderSize);

            wl($"(; {reference.Header} - {Class.Name} ;)");
            indent(() =>
            {
                var meta = Module.MetaClass;

                var dispatch = Class.Dispatches.Count > 0 ? Class.Dispatches.Index : -1;

                var missing = NextAddress - Address - Size;
                var fill = missing > 0 ? $" {Data.EmitZeros(missing)}" : "";

                wl($"(; heap           ;) {Data.EmitInt32(-1)}");
                wl($"(; clazz          ;) {Data.EmitPtr(meta.RuntimeType.Address)}");
                wl($"(; clazz-dispatch ;) {Data.EmitInt32(meta.Dispatches.Index)}");
                wl($"(; size           ;) {Data.EmitUInt32(Class.FieldsSize)}");
                wl($"(; {reference.Payload} ;)");
                wl($"(; name           ;) {Data.EmitPtr(Class.NameConst.Address)}");
                wl($"(; dispatch {dispatch,5} ;) {Data.EmitInt32(dispatch)}");

                wl($"(; fill           ;){fill}");

            });
        }
    }
}
