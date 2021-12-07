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

        public override void MatchCore(Context context)
        {
            var white = Core.__MatchWhite(context.Start);
            if (Dfa!.TryMatch(white, out var done))
            {
                context.Success(done);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
