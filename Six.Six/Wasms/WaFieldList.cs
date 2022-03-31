using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFieldList : WaListOf<WaField>
    {
        public WaFieldList(WaClassy classy)
        {
            Classy = classy;
        }

        public WaClassy Classy { get; }

        public void Prepare()
        {
            uint offset = 0;

            foreach (var field in this)
            {
                offset = field.Type.Align(offset);
                field.Offset = offset;
                offset += field.Type.MemSize;
            }
        }
    }
}
