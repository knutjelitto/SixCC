using System;

namespace Six.Six.Wasms
{
    public class WaRef
    {
        public struct Layout
        {
            public readonly uint Heap;
            public readonly WaPtr ClassPtr;
            public readonly uint DispatchIndex;
            public readonly uint Size;
        }

        public static unsafe readonly uint HeaderSize = (uint)sizeof(Layout);

        public WaRef(WaPtr headerPtr)
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

        public WaPtr Header { get; }
        public static uint HeadOffset => unchecked((uint)0);

        public WaPtr Payload { get; }
        public static uint PayloadOffset => HeaderSize;

        public static uint OffsetOf(uint offset)
        {
            return PayloadOffset + offset;
        }

        public static uint OffsetOfDispatch()
        {
            return HeadOffset + 8;
        }

        public static uint OffsetOfSize()
        {
            return HeadOffset + 12;
        }

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
