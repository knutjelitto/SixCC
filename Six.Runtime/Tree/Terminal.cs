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
            var txt = Source.GetText(Start.Offset, End.Offset - Start.Offset);

            return $"<terminal> {Extend()} '{txt}'";
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher)
        {
            return $"<terminal> {Extend(start, end, matcher)}";
        }
    }
}
