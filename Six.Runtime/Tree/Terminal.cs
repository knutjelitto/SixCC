using Six.Core;
using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public record Terminal(Cursor Start, Cursor End, Matcher Matcher, Source Source)
        : Symbol(Start, End, Matcher)
    {
        public override string ToString()
        {
            return Key(Start, End, Matcher);
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher)
        {
            return $"<terminal> {Extend(start, null, end, matcher)}";
        }
    }
}
