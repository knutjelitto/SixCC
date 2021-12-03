
namespace Six.Runtime.Dfa
{
    public struct DfaSet
    {
        public readonly Interval[] Intervals;

        public DfaSet(params Interval[] intervals)
        {
            Intervals = intervals;
        }

        public DfaSet(params (int min, int max)[] intervals)
        {
            Intervals = intervals.Select(minmax => new Interval(minmax.min, minmax.max)).ToArray();
        }

        public DfaSet(params int[] minOmax)
        {
            Intervals = Enum().ToArray();

            IEnumerable<Interval> Enum()
            {
                for (var i = 0; i < minOmax.Length; i += 2)
                {
                    yield return new Interval(minOmax[i], minOmax[i + 1]);
                }
            }
        }

        [DebuggerStepThrough]
        public bool Match(int value)
        {
            for (var i = 0; i < Intervals.Length; ++i)
            {
                if (value <= Intervals[i].Max)
                {
                    return value >= Intervals[i].Min;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return string.Join(", ", Intervals);
        }
    }
}
