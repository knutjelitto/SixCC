using Six.Runtime;

using static Six.Six.Wasms.WasmData;

namespace Six.Six.Wasms
{
    public class WaMemberFieldList : WaListOf<WaMemberField>
    {
        public WaMemberFieldList(IWithWriter withWriter)
            : base(withWriter)
        {
        }

        public uint Size { get; set; } = uint.MaxValue;

        public override void Prepare()
        {
            uint offset = 0;

            foreach (var field in this)
            {
                offset = field.Type.Align(offset);
                field.Offset = offset;
                offset += field.Type.MemSize;
            }

            Size = offset;
        }
    }

    public class WaStaticFieldList : WaListOf<WaStaticField>
    {
        public WaStaticFieldList(IWithWriter withWriter)
            : base(withWriter)
        {
        }
    }
}
