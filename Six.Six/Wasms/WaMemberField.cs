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
        public WaMemberField(IWithWriter withWriter, string name, WasmType type)
            : base(withWriter, name, type)
        {
        }

        public uint Offset { get; set; } = uint.MaxValue;

        public override void Prepare()
        {
            Assert(Offset < uint.MaxValue);
        }

        public override void Emit()
        {
        }
    }
}
