namespace Six.Core
{
    public class CpString : IReadOnlyList<Codepoint>
    {
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

        public override string ToString()
        {
            return CodepointExtensions.ToString(cps);
        }

        public Codepoint this[int index] => cps[index];
        public int Count => cps.Count;
        public IEnumerator<Codepoint> GetEnumerator() => cps.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)cps).GetEnumerator();
    }
}
