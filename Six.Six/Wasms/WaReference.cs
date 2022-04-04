using System;

namespace Six.Six.Wasms
{
    public class WaReference
    {
        public WaReference()
        {
        }

        public IntPtr Address { get; private set; } = IntPtr.MaxValue;

        public bool Defined => Address != IntPtr.MaxValue;

        public void Define(uint address)
        {
            Address = new IntPtr(address);
        }

        public string Comment => $"(; +{Address,4} 0x{Address:X4} ;)";
    }
}
