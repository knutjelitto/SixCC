using Six.Runtime.Matchers;

namespace Six.Runtime.Tree
{
    [DebuggerStepThrough]
    public sealed record Nonterminal(Cursor Start, Cursor End, Matcher Matcher, params Node[] Children)
        : Symbol(Start, End, Matcher)
    {
        public override string ToString()
        {
            return $"<nonterminal> {Extend()}";
        }

        public static string Key(Cursor start, Cursor end, Matcher matcher)
        {
            return $"<nonterminal> {Extend(start, null, end, matcher)}";
        }
    }
}
