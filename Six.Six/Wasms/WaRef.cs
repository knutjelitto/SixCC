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

        public static unsafe readonly uint HeaderSize = (uint)sizeof(Layout);

        private WaRef(WaPtr headerPtr)
        {
            Assert(HeaderSize == 16);
            Assert(headerPtr.IsValid);

            Header = headerPtr;
            Payload = Header.Offset(HeaderSize);
        }

        public static WaRef FromHeaderAddress(uint headerAddress)
        {
            return new WaRef(WaPtr.Null.Offset(headerAddress));
        }

        public static WaRef FromHeaderAddress(WaPtr headerPtr)
        {
            return new WaRef(headerPtr);
        }

        public static WaRef FromContentAddress(WaPtr contentPtr)
        {
            return new WaRef(WaPtr.Null.Offset(unchecked((uint)(contentPtr.Address - HeaderSize))));
        }

        public WaPtr Header { get; }
        public static uint HeadOffset => unchecked((uint)0);

        public WaPtr Payload { get; }
        public static uint PayloadOffset => HeaderSize;

        public static uint OffsetOf(uint offset)
        {
            return PayloadOffset + offset;
        }

        public static uint OffsetOfDummy => HeadOffset + 0;

        public static uint OffsetOfClass => HeadOffset + 4;

        public static uint OffsetOfDispatch => HeadOffset + 8;

        public static uint OffsetOfSize => HeadOffset + 12;

        public static uint OffsetOfPayload()
        {
            return PayloadOffset;
        }

        public uint this[uint offset] => PayloadOffset + offset;

        public override string ToString()
        {
            return $"ref [{Header.Address},{Payload.Address}]";
        }
    }
}
