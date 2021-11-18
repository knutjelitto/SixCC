using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Six.Core
{
    public sealed class CpString : IReadOnlyList<Codepoint>
    {
        private int? hash;
        private readonly List<Codepoint> cps;


        public CpString(IEnumerable<Codepoint> cps)
        {
            this.cps = cps.ToList();
        }

        public CpString(string str)
            : this(str.Codepoints())
        {
        }

        public CpString(char chr)
            : this(chr.Codepoints())
        {
        }

        public CpString(int cp)
            : this(char.ConvertFromUtf32(cp))
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CpString other && cps.SequenceEqual(other.cps);
        }

        public override int GetHashCode() => hash ??= cps.Hash();
        public override string ToString() => CodepointExtensions.ToString(cps);

        public Codepoint this[int index] => cps[index];
        public int Count => cps.Count;
        public IEnumerator<Codepoint> GetEnumerator() => cps.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)cps).GetEnumerator();
    }
}
