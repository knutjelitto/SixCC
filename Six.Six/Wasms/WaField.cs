using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public class WaField
    {
        public WaField(string name, WasmType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public WasmType Type { get; }
        public uint Offset { get; set; }
    }
}
