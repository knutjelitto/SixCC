namespace Six.Six.Wasms
{
    public struct WaPtr
    {
        public static readonly WaPtr Invalid = new(uint.MaxValue);
        public static readonly WaPtr Null = new(0);

        private WaPtr(uint address)
        {
            Address = address;
        }

        public WaPtr Offset(uint offset)
        {
            return new WaPtr(Address + offset);
        }

        public bool IsValid => Address < uint.MaxValue;

        public uint Address { get; }

        public static uint operator -(WaPtr ptr1, WaPtr ptr2)
        {
            Assert(ptr2 < ptr1);
            return ptr1.Address - ptr2.Address;
        }

        public static bool operator <(WaPtr ptr1, WaPtr ptr2)
        {
            return ptr1.Address < ptr2.Address;
        }

        public static bool operator >(WaPtr ptr1, WaPtr ptr2)
        {
            return ptr1.Address > ptr2.Address;
        }
    }
}
