using Six.Runtime.Matchers;

namespace Six.Runtime.Sppf
{
    [DebuggerStepThrough]
    public sealed class Nonterminal : Symbol
    {
        public Nonterminal(Role role, Matcher matcher, Cursor start, Cursor end, params Node[] children)
            : base(matcher, start, end, children)
        {
            Role = role;
        }

        public Role Role { get; }

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
