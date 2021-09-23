using SixCC.Runtime.Commons;
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    public sealed class IntegerSet : IEnumerable<int>, IEquatable<IntegerSet>
    {
        public static IntegerSet Empty => new();

        private readonly List<Interval> ranges;

        public IntegerSet(params (int min, int max)[] ranges)
            : this(ranges.Select(p => new Interval(p.min, p.max)))
        {
        }

        private IntegerSet(Interval range)
            : this(Enumerable.Repeat(range, 1))
        {
        }

        private IntegerSet()
            : this(Enumerable.Empty<Interval>())
        {
        }

        private IntegerSet(IntegerSet other)
            : this(other.ranges)
        {
        }

        private IntegerSet(IEnumerable<Interval> ranges)
        {
            this.ranges = new List<Interval>(ranges);
        }

        public int Cardinality => ranges.Sum(range => range.Count);

        public bool IsEmpty => ranges.Count == 0;

        public int Max => ranges.Last().Max;

        public int Min => ranges.First().Min;

        public int Single
        {
            get
            {
                Debug.Assert(Min == Max);
                return Min;
            }
        }

        public int IntervalCount => ranges.Count;

        public static IntegerSet From(IntegerSet other)
        {
            return new IntegerSet(other);
        }

        public static IntegerSet From(int minmax)
        {
            return new IntegerSet(new Interval(minmax));
        }

        public static IntegerSet From(int min, int max)
        {
            return new IntegerSet(new Interval(min, max));
        }

        public static IntegerSet? Parse(string str)
        {
            if (TryParse(str, out var set))
            {
                return set;
            }
            return null;
        }

        public static bool TryParse(string str, [MaybeNullWhen(false)] out IntegerSet? set)
        {
            if (str.Length == 0 || str[0] != '[')
            {
                set = null;
                return false;
            }

            var start = 1;
            var end = 1;
            set = new IntegerSet();
            while (end < str.Length)
            {
                while (end < str.Length && str[end] != ',' && str[end] != ']')
                {
                    end += 1;
                }
                if (end > start && Interval.TryParse(str[start..end], out var range))
                {
                    set.Add(range);
                    start = ++end;
                }
                else
                {
                    break;
                }
            }

            if (end == str.Length)
            {
                return true;
            }

            set = null;
            return false;
        }

        public void Add(int value)
        {
            Add(new Interval(value));
        }

        public void Add(params (int min, int max)[] rangesToAdd)
        {
            Add(rangesToAdd.Select(range => new Interval(range.min, range.max)));
        }

        public void Add(IntegerSet other)
        {
            Add(other.ranges);
        }

        public IntegerSet Clone()
        {
            return new IntegerSet(ranges);
        }

        public bool Contains(int value)
        {
            return Find(value, out var _);
        }

        public override bool Equals(object? obj)
        {
            return obj is IntegerSet other && ranges.SequenceEqual(other.ranges);
        }

        public bool Equals(IntegerSet? other)
        {
            return other != null && ranges.SequenceEqual(other.ranges);
        }

        public IntegerSet ExceptWith(IntegerSet other)
        {
            var set = Clone();
            set.Sub(other.ranges);
            return set;
        }

        public IntegerSet IntersectWith(IntegerSet other)
        {
            var union = UnionWith(other);
            var ex1 = ExceptWith(other);
            var ex2 = other.ExceptWith(this);

            return union.ExceptWith(ex1).ExceptWith(ex2);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var range in ranges)
            {
                foreach (var value in range)
                {
                    yield return value;
                }
            }
        }

        public override int GetHashCode()
        {
            return ranges.Hash();
        }

        public IEnumerable<(int Min, int Max)> GetIntervals()
        {
            return ranges.Select(r => (r.Min, r.Max));
        }

        public IEnumerable<int> GetValues()
        {
            return ranges.SelectMany(range => range);
        }

        public bool IsProperSubsetOf(IntegerSet other)
        {
            return IsSubsetOf(other) && !Equals(other);
        }

        public bool IsProperSupersetOf(IntegerSet other)
        {
            return IsSupersetOf(other) && !Equals(other);
        }

        public bool IsSubsetOf(IntegerSet other)
        {
            foreach (var range in ranges)
            {
                if (!other.Contains(range))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSupersetOf(IntegerSet other)
        {
            return other.IsSubsetOf(this);
        }

        public bool Overlaps(IntegerSet other)
        {
            var t = 0;
            var o = 0;

            while (t < ranges.Count && o < other.ranges.Count)
            {
                while (t < ranges.Count && o < other.ranges.Count && ranges[t].Max < other.ranges[o].Min)
                {
                    t += 1;
                }

                while (t < ranges.Count && o < other.ranges.Count && other.ranges[o].Max < ranges[t].Min)
                {
                    o += 1;
                }

                if (t < ranges.Count && o < other.ranges.Count && other.ranges[o].Overlaps(ranges[t]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Sub(int value)
        {
            Sub(new Interval(value));
        }

        public void Sub(params (int min, int max)[] rangesToSub)
        {
            Sub(rangesToSub.Select(range => new Interval(range.min, range.max)));
        }

        public IntegerSet Substract(IntegerSet other)
        {
            return Clone().Sub(other.ranges);
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", ranges)}]";
        }

        public string ToIString()
        {
            return $"[{string.Join(", ", ranges.Select(r => r.ToIString()))}]";
        }

        public IntegerSet UnionWith(IntegerSet other)
        {
            var set = Clone();
            set.Add(other.ranges);
            return set;
        }

        public static IntegerSet operator +(IntegerSet set1, IntegerSet set2)
        {
            return set1.UnionWith(set2);
        }

        public static IntegerSet operator /(IntegerSet set1, IntegerSet set2)
        {
            return set1.ExceptWith(set2);
        }


        public static explicit operator IntegerSet(char ch)
        {
            return From(ch);
        }

        private void Add(Interval add)
        {
            var i = 0;
            while (i < ranges.Count)
            {
                var current = ranges[i];

                if (add.Min > current.Max + 1)
                {
                    ++i;
                    continue;
                }

                if (add.Max + 1 < current.Min)
                {
                    // before current
                    ranges.Insert(i, add);
                    return;
                }

                if (add.Max <= current.Max)
                {
                    // combine with current
                    ranges[i] = new Interval((char)Math.Min(add.Min, current.Min), current.Max);
                    return;
                }

                add = new Interval((char)Math.Min(add.Min, current.Min), add.Max);
                ranges.RemoveAt(i);
            }

            if (i == ranges.Count)
            {
                ranges.Add(add);
            }
        }

        private void Add(IEnumerable<Interval> rangesToAdd)
        {
            foreach (var range in rangesToAdd)
            {
                Add(range);
            }
        }

        private bool Contains(Interval range)
        {
            return Find(range.Min, out var found) && range.Max <= found.Max;
        }

        private bool Find(int value, out Interval range)
        {
            bool Find(int lower, int upper, out Interval found)
            {
                if (upper < lower)
                {
                    found = default;
                    return false;
                }

                var mid = lower + (upper - lower) / 2;

                if (ranges[mid].Contains(value))
                {
                    found = ranges[mid];
                    return true;
                }
                if (value < ranges[mid].Min)
                {
                    return Find(lower, mid - 1, out found);
                }
                return Find(mid + 1, upper, out found);
            }

            return Find(0, ranges.Count - 1, out range);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Sub(Interval sub)
        {
            var i = 0;

            while (i < ranges.Count)
            {
                var range = ranges[i];

                if (sub.Max < range.Min)
                {
                    i += 1;
                    continue;
                }

                if (range.Max < sub.Min)
                {
                    i += 1;
                    continue;
                }

                if (sub.Min <= range.Min)
                {
                    // cover from below
                    if (sub.Max >= range.Max)
                    {
                        // full cover
                        ranges.RemoveAt(i);
                    }
                    else
                    {
                        ranges[i] = new Interval(sub.Max + 1, range.Max);
                        i += 1;
                    }
                    continue;
                }

                if (range.Max <= sub.Max)
                {
                    // cover from above
                    if (range.Min >= sub.Min)
                    {
                        // full cover
                        ranges.RemoveAt(i);
                    }
                    else
                    {
                        ranges[i] = new Interval(range.Min, sub.Min - 1);
                        i += 1;
                    }
                    continue;
                }

                // inner
                // sub.Min > range.Min && range.Max > sub.Max
                ranges.Insert(i, new Interval(range.Min, sub.Min - 1));
                ranges[i + 1] = new Interval(sub.Max + 1, range.Max);
                // done
                break;
            }
        }

        private IntegerSet Sub(IEnumerable<Interval> rangesToSub)
        {
            foreach (var range in rangesToSub)
            {
                Sub(range);
            }

            return this;
        }

        private struct Interval : IEnumerable<int>
        {
            public Interval(int minmax)
            {
                Min = minmax;
                Max = minmax;
            }

            public Interval(int min, int max)
            {
                Debug.Assert(min <= max);
                Min = min;
                Max = max;
            }

            public int Min { get; private set; }
            public int Max { get; private set; }
            public int Count => Max - Min + 1;

            public bool Contains(int value)
            {
                return Min <= value && value <= Max;
            }

            public bool Overlaps(Interval other)
            {
                return Contains(other.Min) || Contains(other.Max) || other.Contains(Min) || other.Contains(Max);
            }

            public IEnumerator<int> GetEnumerator() => Enumerable.Range(Min, Count).GetEnumerator();

            public string ToIString()
            {
                if (Min == Max)
                {
                    return $"{Min}";
                }
                if (Min == Max - 1)
                {
                    return $"{Min}, {Max}";
                }
                if (Min == Max - 2)
                {
                    return $"{Min}, {Max - 1}, {Max}";
                }
                if (Min == Max - 3)
                {
                    return $"{Min}, {Max - 2}, {Max - 1}, {Max}";
                }

                if (Min == Max - 4)
                {
                    return $"{Min}, {Max - 3}, {Max - 2}, {Max - 1}, {Max}";
                }

                return $"{Min} - {Max}";
            }

            public override string ToString()
            {
                if (Min == Max)
                {
                    return CharRep.InRange(Min);
                }
                if (Max - Min <= 3)
                {
                    return string.Join(", ", Enumerable.Range(Min, Max-Min+1).Select(x => CharRep.InRange(x)));
                }

                return $"{CharRep.InRange(Min)}..{CharRep.InRange(Max)}";
            }

            public static bool TryParse(string str, out Interval range)
            {
                var end = 0;
                while (end < str.Length && char.IsDigit(str, end))
                {
                    end += 1;
                }
                if (end > 0)
                {
                    if (end == str.Length)
                    {
                        if (int.TryParse(str, out var minmax))
                        {
                            range = new Interval(minmax);
                            return true;
                        }
                    }
                    else if (str[end] == '-' && int.TryParse(str.AsSpan(0, end), out var min))
                    {
                        var start = ++end;
                        while (end < str.Length && char.IsDigit(str, end))
                        {
                            end += 1;
                        }
                        if (end > start && end == str.Length)
                        {
                            if (int.TryParse(str.AsSpan(start, end - start), out var max))
                            {
                                range = new Interval(min, max);
                                return true;
                            }
                        }
                    }
                }

                range = default;
                return false;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public override bool Equals(object? obj)
            {
                return obj is Interval other && Min == other.Min && Max == other.Max;
            }

            public override int GetHashCode() => (Min, Max).GetHashCode();
        }
    }
}