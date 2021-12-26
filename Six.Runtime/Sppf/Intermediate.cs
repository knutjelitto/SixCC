using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public sealed class Intermediate : Symbol
    {
        public Intermediate(Matcher matcher, Cursor start, Cursor end, int dot, params Node[] children)
            : base(matcher, start, end, children)
        {
            Dot = dot;
        }

        public int Dot { get; }

        public override string ToString()
        {
            return Key(Matcher, Start, End, Dot);
        }

        public static string Key(Matcher matcher, Cursor start, Cursor end, int dot)
        {
            return $"<intermediate> {Extend(matcher, start, end, null)} @{dot}";
        }
    }
}
