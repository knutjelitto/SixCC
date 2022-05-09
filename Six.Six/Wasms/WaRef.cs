using System;

namespace Six.Six.Wasms
{
    public sealed class WaRef
    {
        public struct Layout
        {
            /* + 0 */ public readonly uint Heap;
            /* + 4 */ public readonly uint ObjectId;
            /* + 8 */ public readonly uint Dispatch;
            /* +12 */ public readonly uint Size;
            /* +16 */ // Size bytes
        }

        public static class Head
        {
            public const uint Heap = 0;
            public const uint ObjectId = 4;
            public const uint Dispatch = 8;
            public const uint Size = 12;
        }

        public static unsafe readonly uint HeaderSize = (uint)sizeof(Layout);

        private WaRef(WaPtr objectPtr)
        {
            Assert(HeaderSize == 16);
            Assert(objectPtr.IsValid);

            Object = objectPtr;
            Header = objectPtr.Offset(HeadOffset);
        }

        public static WaRef FromObjectAddress(WaPtr objectPtr)
        {
            return new WaRef(objectPtr);
        }

        public static WaRef FromObjectAddress(uint objectAddress)
        {
            return FromObjectAddress(WaPtr.Null.Offset(objectAddress));
        }

        public WaPtr Header { get; }
        public static uint HeadOffset => unchecked((uint)-HeaderSize);

        public WaPtr Object { get; }
        public static uint ObjectOffset => 0;

        public static uint OffsetOf(uint offset)
        {
            return ObjectOffset + offset;
        }

        public uint this[uint offset] => ObjectOffset + offset;

        public override string ToString()
        {
            return $"ref [{Header.Address},{Object.Address}]";
        }
    }
}
