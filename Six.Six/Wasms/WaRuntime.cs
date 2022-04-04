using Six.Runtime;
using static Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaRuntime : WithWriter, Wamber
    {
        public static uint PayloadOffset = 8;

        public WaRuntime(WaClass clazz)
            : base(clazz.Writer)
        {
            Class = clazz;
            Module = clazz.Module;
        }

        public WaClass Class { get; }
        public WaModule Module { get; }

        public uint Address { get; set; } = uint.MaxValue;
        public uint Payload => Address + PayloadOffset;
        public uint Size { get; private set; } = 0;

        public void Prepare()
        {
            Size = 20;
        }

        public void Emit()
        {
            wl($"(; +{Address,4} 0x{Address:X4} - {Class.Name} ;)");
            indent(() =>
            {
                var dispatch = Class.Dispatches.Count > 0 ? Class.Dispatches.Index : -1;

                wl($"(; clazz          ;) {EmitUInt32(Module.MetaClass.RuntimeType.Address)}");
                wl($"(; clazz-dispatch ;) {EmitUInt32((uint)Module.MetaClass.Dispatches.Index)}");
                wl($"(; size           ;) {EmitUInt32(8 + Class.FieldsSize)}");
                wl($"(; name           ;) {EmitAddress(Class.NameConst.Address)}");
                wl($"(; dispatch {dispatch,5} ;) {EmitUInt32((uint)dispatch)}");
            });
        }
    }
}
