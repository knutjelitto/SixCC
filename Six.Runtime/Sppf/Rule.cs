#if false
using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public record Rule(Matcher Matcher, Cursor Start, Cursor End, params Node[] Children)
        : Nonterminal(Matcher, Start, End, Children)
    {
        public override string ToString()
        {
            return Key(Matcher, Start, End);
        }

        public static new string Key(Matcher matcher, Cursor start, Cursor end)
        {
            return $"<rule> {Extend(matcher, start, end, null)}";
        }
    }
}
#endif