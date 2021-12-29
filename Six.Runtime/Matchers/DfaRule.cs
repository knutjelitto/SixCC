namespace Six.Runtime.Matchers
{
    public class DfaRule : Rule
    {
        public Dfa.Dfa? Dfa = null;

        public DfaRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public void Set(Dfa.Dfa dfa)
        {
            Dfa = dfa;
        }

        public override bool IsTerminal => true;

        public override void MatchCore(Context context)
        {
            if (context.Nexts.Count > 0)
            {
                Assert(context.Nexts.Count == 1);
                context.Success(context.Nexts.First());
            }
            Assert(context.Nexts.Count == 0);

            context.Core = Core.__MatchWhite(context.Start);
            if (Dfa!.TryMatch(context.Core, out var matched))
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
