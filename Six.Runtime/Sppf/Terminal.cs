using Six.Core;
using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public record Terminal(Matcher Matcher, Cursor Start, Cursor End, Source Source)
        : Symbol(Matcher, Start, End)
    {
        public override string ToString()
        {
            return Key(Matcher, Start, End);
        }

        public static string Key(Matcher matcher, Cursor start, Cursor end)
        {
            return $"<terminal> {Extend(matcher, start, end, null)}";
        }
    }
}
