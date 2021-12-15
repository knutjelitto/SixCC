using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    public sealed record Intermediate(Matcher Matcher, Cursor Start, Cursor End, int Dot, params Node[] Children)
        : Symbol(Matcher, Start, End, Children)
    {
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
