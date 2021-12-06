namespace Six.Runtime.Matchers
{
    public record WhiteRule(ImplementationCore Core, int Id, string Name) : DfaRule(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Assert(Dfa != null);
            Dfa.Match(new Context(context.Start,
                success =>
                {
                    context.Success(success);
                }));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
