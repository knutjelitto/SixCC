using SixCC.Core;
using SixCC.Runtime.Commons;

namespace SixCC.Runtime.Lexing
{
    public struct Interval
    {
        public readonly int Min;
        public readonly int Max;

        public Interval(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            if (Max == 0x10FFFF)
            {
                return $"{CharRep.InRange(Min)}-{CharRep.InRange(Max)}";
            }
            var chars = Enumerable.Range(Min, Max - Min + 1).Select(n => CharRep.InRange(n));
            return string.Join(", ", chars);
        }
    }
}
