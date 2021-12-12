using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    public sealed record Intermediate(Cursor Start, Cursor End, Matcher Matcher, int Dot, params Packed[] Children)
        : Symbol(Start, End, Matcher)
    {
        public override string ToString()
        {
            return Key(Start, End, Matcher, Dot);
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher, int dot)
        {
            return $"<intermediate> {Extend(start, null, end, matcher)} @{dot}";
        }
    }
}
