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
        public WaMemberField(IWithWriter withWriter, string name, uint offset, WasmType type)
            : base(withWriter, name, type)
        {
            Offset = offset;
        }

        public uint Offset { get; }

        public override void Prepare()
        {
            Assert(Offset < uint.MaxValue);
        }

        public override void Emit()
        {
        }
    }
}
