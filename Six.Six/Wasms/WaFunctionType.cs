using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public class WaFunctionType
    {
        public WaFunctionType(WAFunctionTypeList types, string signature, uint index)
        {
            Types = types;
            Signature = signature;
            Index = index;
            Name = $"funcType{Index}";
        }

        public WAFunctionTypeList Types { get; }
        public string Signature { get; }
        public uint Index { get; }
        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
