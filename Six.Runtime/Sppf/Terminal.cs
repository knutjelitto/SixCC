using Six.Core;
using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public sealed class Terminal : Symbol
    {
        public Terminal(Matcher matcher, Cursor start, Cursor core, Cursor end, Source source)
            : base(matcher, start, end)
        {
            Core = core;
            Source = source;
        }

        public Cursor Core { get; }
        public Source Source { get; }

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
