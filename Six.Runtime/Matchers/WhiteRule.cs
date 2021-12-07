namespace Six.Runtime.Matchers
{
    public sealed record WhiteRule(ImplementationCore Core, int Id, string Name)
        : DfaRule(Core, Id, Name)
    {
        public override void MatchCore(Context context)
        {
            Assert(Dfa != null);
            Dfa.Match(context);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
