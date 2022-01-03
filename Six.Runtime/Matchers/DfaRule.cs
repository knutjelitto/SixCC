namespace Six.Runtime.Matchers
{
    public class DfaRule : Rule
    {
        public DfaRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override bool IsTerminal => true;

        public override void MatchCore(Context context)
        {
            Assert(Dfa != null);

            context.Core = Core.__MatchWhite(context.Start);
            if (Dfa.TryMatch(context.Core, out var matched))
            {
                context.Success(matched);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
