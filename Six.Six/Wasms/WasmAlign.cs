namespace Six.Six.Wasms
{
    public static class WasmAlign
    {
        public static uint Align16(uint offset)
        {
            return Align(16, offset);
        }

        public static uint Align8(uint offset)
        {
            return Align(8, offset);
        }

        public static uint Align(uint align, uint offset)
        {
            return (offset + (align - 1)) & ~(align - 1);
        }

        public static uint AlignCount(uint offset)
        {
            return WasmType.I32.Align(offset);
        }
    }
}
