using System;

namespace Six.Six.Wasms
{
    public class WaRef
    {
        public static unsafe readonly uint HeadSize = (uint)sizeof(Layout);

        public struct Layout
        {
            public readonly WaPtr ClassPtr;
            public uint DispatchIndex;
        }

        public WaRef(WaPtr headPtr)
        {
            Assert(headPtr.IsValid);

            HeadPtr = headPtr;

            Assert(HeadSize == 8);
        }

        public WaPtr HeadPtr { get; }

        public WaPtr PayloadPtr => HeadPtr.Offset(HeadSize);

        public string Comment => $"(; {HeadPtr} ;)";
    }
}
