using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaMemberFieldList : WaListOf<WaMemberField>
    {
        public WaMemberFieldList(WaClass @class)
            : base(@class)
        {
            Class = @class;
        }

        public WaClass Class { get; }
        public uint Size { get; set; } = uint.MaxValue;

        public override void Prepare()
        {
            Size = 0;

            if (Count > 0)
            {
                Assert(this[0].Offset == 0);

                var last = this[Count - 1];
                Size = last.Offset + last.Size;
            }
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
