using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public sealed record Nonterminal(Role Role, Matcher Matcher, Cursor Start, Cursor End, params Node[] Children)
        : Symbol(Matcher, Start, End, Children)
    {
        public override string ToString()
        {
            return Key(Role, Matcher, Start, End);
        }

        public static string Key(Role role, Matcher matcher, Cursor start, Cursor end)
        {
            return $"<{role.ToString().ToLowerInvariant()}> {Extend(matcher, start, end, null)}";
        }
    }
}
