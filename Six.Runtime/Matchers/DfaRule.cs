namespace Six.Runtime.Matchers
{
    public record DfaRule(ImplementationCore Core, int Id, string Name)
        : Rule(Core, Id, Name)
    {
        public Dfa.Dfa? Dfa = null;

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
