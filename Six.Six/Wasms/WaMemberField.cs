using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public class WaMemberField : WaField
    {
        public WaMemberField(IWithWriter withWriter, string name, uint offset, uint size, WasmType type)
            : base(withWriter, name, type)
        {
            Offset = offset;
            Size = size;
        }

        public uint Offset { get; }
        public uint Size { get; } 

        public override void Prepare()
        {
            Assert(Offset < uint.MaxValue);
            Assert(Size < uint.MaxValue);
        }

        public override void Emit()
        {
        }

        public override string ToString()
        {
            return $"field {Name}";
        }
    }
}
